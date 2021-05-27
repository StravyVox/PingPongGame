using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Windows;
using System.Windows.Input;
using PingPongGraphicsClassLibrary;
namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class MainEngine.
    /// Implements the <see cref="System.IDisposable" />
    /// </summary>
    /// <seealso cref="System.IDisposable" />
   public class MainEngine :IDisposable
    {
        /// <summary>
        /// The main objects
        /// </summary>
        MainGameObjectsWorker _MainObjects;
        /// <summary>
        /// The main window game
        /// </summary>
        RenderForm _mainWindowGame;
        /// <summary>
        /// The game logic
        /// </summary>
        GameLogic _GameLogic;
        /// <summary>
        /// The frame drawer
        /// </summary>
        FrameDrawer _FrameDrawer;
        /// <summary>
        /// Initializes a new instance of the <see cref="MainEngine"/> class.
        /// </summary>
        /// <param name="mainForm">The main form.</param>
        public MainEngine(RenderForm mainForm)
        {
            _MainObjects = new MainGameObjectsWorker();
            _mainWindowGame = mainForm;
            _FrameDrawer = new FrameDrawer(_mainWindowGame);
            _GameLogic = new GameLogic(_mainWindowGame, _MainObjects);
            _mainWindowGame = mainForm;
        }


        /// <summary>
        /// Restarts this instance.
        /// </summary>
        public void Restart()
        {
        if (ControlersChecker.IsDownKeyPressed(Key.Space)) {
                _MainObjects = new MainGameObjectsWorker();
                _FrameDrawer = new FrameDrawer(_mainWindowGame);
                _GameLogic = new GameLogic(_mainWindowGame, _MainObjects); }
        }
        /// <summary>
        /// Logics this instance.
        /// </summary>
        public void Logic()
        {
            if (_GameLogic._GameIsPlaying == true)
            {
                if (_GameLogic.RoundStatus == true)
                {
                    _GameLogic.DoFrameLogic();
                }
                else
                    _GameLogic.RoundRestart();
            }
            else Restart();
        }
        /// <summary>
        /// Frames the draw.
        /// </summary>
        public void FrameDraw()
        {
            _FrameDrawer.SpritesDraw(_MainObjects.ReturnSpritesMass(), _MainObjects.ReturnPositionX(), _MainObjects.ReturnPositionY(), _MainObjects.ReturnScales());
            _FrameDrawer.ScoreDraw(_MainObjects.FirstPlayerGet.Score, _MainObjects.SecondPlayerGet.Score);
        }
        /// <summary>
        /// Выполняет определяемые приложением задачи, связанные с удалением, высвобождением или сбросом неуправляемых ресурсов.
        /// </summary>
        public void Dispose()
        {
            _FrameDrawer.Dispose();
        }
    }

}
