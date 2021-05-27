using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;
using SharpDX.Windows;
namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class GameLogic.
    /// </summary>
    public class GameLogic
    {
        /// <summary>
        /// The frame objects
        /// </summary>
        public MainGameObjectsWorker _FrameObjects;
        /// <summary>
        /// The game is playing
        /// </summary>
        public bool _GameIsPlaying;
        /// <summary>
        /// The round is playing
        /// </summary>
        public bool _RoundIsPlaying;
        /// <summary>
        /// The rounds played
        /// </summary>
        private int _RoundsPlayed;
        /// <summary>
        /// The main window game
        /// </summary>
        private RenderForm _mainWindowGame;
        /// <summary>
        /// The boxes
        /// </summary>
        public List<BonusBox> _boxes;
        /// <summary>
        /// The bonus maker
        /// </summary>
        BonusMaker _bonusMaker;
        /// <summary>
        /// The time bonus helper
        /// </summary>
        public Stopwatch _timeBonusHelper;
        /// <summary>
        /// Initializes a new instance of the <see cref="GameLogic"/> class.
        /// </summary>
        /// <param name="mainWindowGame">The main window game.</param>
        /// <param name="FrameWorker">The frame worker.</param>
        public GameLogic(RenderForm mainWindowGame, MainGameObjectsWorker FrameWorker)
        {
            _FrameObjects = FrameWorker;
            _mainWindowGame = mainWindowGame;
            _GameIsPlaying = true;
            _RoundIsPlaying = true;
            _bonusMaker = new BonusMaker(mainWindowGame);
            _boxes = new List<BonusBox>();
            _RoundsPlayed = 1;
            _timeBonusHelper = new Stopwatch();
            _timeBonusHelper.Start();
        }
        /// <summary>
        /// Gets or sets a value indicating whether [round status].
        /// </summary>
        /// <value><c>true</c> if [round status]; otherwise, <c>false</c>.</value>
        public bool RoundStatus
        {
            get
            {
                return _RoundIsPlaying;
            }
            set
            {
                _RoundIsPlaying = value;
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether [game status].
        /// </summary>
        /// <value><c>true</c> if [game status]; otherwise, <c>false</c>.</value>
        public bool GameStatus
        {
            get
            {
                return _GameIsPlaying;
            }
            set
            {
                _GameIsPlaying = value;
            }
        }


        /// <summary>
        /// Does the frame logic.
        /// </summary>
        public void DoFrameLogic()
        {
            if (_timeBonusHelper.ElapsedMilliseconds >=5000)
            {
                _boxes.Add(_bonusMaker.ToMakeABonus());
                _timeBonusHelper.Reset();
                _timeBonusHelper.Start();
            }
            _FrameObjects.CurrentBall.FrameLogic(_mainWindowGame.Height);

            BonusHit();
            ControlsLogic();
            _FrameObjects.CurrentBall.CheckHitRightPaddle(_FrameObjects.FirstPlayerGet, _mainWindowGame.Width);
            _FrameObjects.CurrentBall.CheckHitLeftPaddle(_FrameObjects.SecondPlayerGet);
            RoundOver();
            _FrameObjects.AddBoxes(_boxes);
        }
        /// <summary>
        /// Controlses the logic.
        /// </summary>
        private void ControlsLogic()
        {

            if (ControlersChecker.IsDownKeyPressed(Key.Down))
                _FrameObjects.FirstPlayerGet.MoveToPosition(10, _mainWindowGame.Height);
            if (ControlersChecker.IsDownKeyPressed(Key.Up))
                _FrameObjects.FirstPlayerGet.MoveToPosition(-10, _mainWindowGame.Height);
            if (ControlersChecker.IsDownKeyPressed(Key.W))
                _FrameObjects.SecondPlayerGet.MoveToPosition(-10, _mainWindowGame.Height);
            if (ControlersChecker.IsDownKeyPressed(Key.S))
                _FrameObjects.SecondPlayerGet.MoveToPosition(10, _mainWindowGame.Height);
        }
        /// <summary>
        /// Bonuses the hit.
        /// </summary>
        public void BonusHit()
        {
            for (int i = 0; i < _boxes.Count; i++)
            {
                if (_FrameObjects.CurrentBall.CheckHitBonusBox(_boxes[i]))
                {
                    if (_boxes[i].BonusType == "SpeedBall")
                    {
                        _FrameObjects.CurrentBall = (Ball)DecoratorWorker.ToReturnDecoratorForBall(_boxes[i], _FrameObjects.CurrentBall);
                    }
                    else
                    {
                        if (_FrameObjects.CurrentBall.SpeedX >= 0)
                        {
                            _FrameObjects.FirstPlayerGet = (FirstPlayer)DecoratorWorker.ToReturnADecoratorForPaddle(_boxes[i], _FrameObjects.FirstPlayerGet);
                        }
                        else
                        {
                            _FrameObjects.SecondPlayerGet = (SecondPlayer)DecoratorWorker.ToReturnADecoratorForPaddle(_boxes[i], _FrameObjects.SecondPlayerGet);
                        }
                    }
                    _boxes.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// Rounds the over.
        /// </summary>
        public void RoundOver()
        {
            if (_FrameObjects.CurrentBall.IsOutsideLeft())
            {
                _RoundIsPlaying = false;
                _FrameObjects.SecondPlayerGet.AddScore();
            }
            if (_FrameObjects.CurrentBall.IsOutsideRight(_mainWindowGame.Width))
            {
                _RoundIsPlaying = false;
                _FrameObjects.FirstPlayerGet.AddScore();
            }
            if (_FrameObjects.FirstPlayerGet.Score >10 || _FrameObjects.SecondPlayerGet.Score > 10)
            {
                _GameIsPlaying = false;
            }
        }
        /// <summary>
        /// Rounds the restart.
        /// </summary>
        public void RoundRestart()
        {
            _RoundsPlayed++;
            int frstscore = _FrameObjects.FirstPlayerGet.Score;
            int scndscore = _FrameObjects.SecondPlayerGet.Score; 
            _FrameObjects.RestartPlayers();
            _FrameObjects.ResetBoxes();
            _boxes.RemoveRange(0,_boxes.Count);
            _FrameObjects.FirstPlayerGet.Score = frstscore;
            _FrameObjects.SecondPlayerGet.Score = scndscore;
            if ((_RoundsPlayed/2)%2==0 || _RoundsPlayed==2)
            {
                _FrameObjects.CurrentBall.Reset(1);
            }
            else
            {
                _FrameObjects.CurrentBall.Reset(2);
            }
            _RoundIsPlaying = true;
        }
    }

}
