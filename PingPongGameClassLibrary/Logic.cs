using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;
using SharpDX.Windows;
namespace PingPongGameClassLibrary
{
    class Logic
    {
        ObjectsMassWorker ObjectsList;
        public bool _GameIsPlaying;
        private Ball _mainBall;
        private Paddle _frstPaddle;
        private Paddle _scndPaddle;
        private RenderForm _mainWindowGame;
        //List<BonuseBox> _boxes;
        ControlersChecker _ControllerHelper;
        public Logic(RenderForm mainWindowGame, ObjectsMassWorker ObjList)
        {
            ObjectsList = ObjList;
            ObjectsList.Add(new Background());
            ObjectsList.Add(new Ball());
            ObjectsList.Add(new Paddle(765, 300));
            ObjectsList.Add(new Paddle(0, 300, @"D:\Downloads\platform1.png"));
            _mainBall = (Ball)ObjectsList[1];
            _frstPaddle = (Paddle)ObjectsList[2];
            _scndPaddle = (Paddle)ObjectsList[3];
            _mainWindowGame = mainWindowGame;
            _GameIsPlaying = true;
            _ControllerHelper = new ControlersChecker();
        }
        public void GameLogic()
        {
        
                _mainBall.Advance(_mainWindowGame.Height);
            if (_ControllerHelper.IsDownKeyPressed(Key.Down))
                _frstPaddle.MoveToPosition(10,_mainWindowGame.Height);
            if(_ControllerHelper.IsDownKeyPressed(Key.Up))
                _frstPaddle.MoveToPosition(-10, _mainWindowGame.Height);
            if (_ControllerHelper.IsDownKeyPressed(Key.W))
                _scndPaddle.MoveToPosition(-10,_mainWindowGame.Height);
            if (_ControllerHelper.IsDownKeyPressed(Key.S))
                _scndPaddle.MoveToPosition(10, _mainWindowGame.Height);

            /* if (Keyboard.IsKeyDown(Key.Space) == true)
             {
                 _mainBall.Bust();
             }*/

            /*foreach(BonuseBox boxes in _boxes){
                if(boxes.Iftouched(_mainball.PosX, _mainball.PosY)==true)
            }
            */
            _mainBall.CheckHitRightPaddle(_frstPaddle._positionY, _mainWindowGame.Width);
                _mainBall.CheckHitLeftPaddle(_scndPaddle._positionY);
                if (_mainBall.IsOutsideLeft())
                {
                    _GameIsPlaying = false;
                    _scndPaddle.IncreaseScore();
                }
                if (_mainBall.IsOutsideRight(_mainWindowGame.Width))
                {
                    _GameIsPlaying = false;
                    _frstPaddle.IncreaseScore();
                }
            ReturnToMassObjects();
        }
        public void ReturnToMassObjects()
        {
            ObjectsList[1] = _mainBall;
            ObjectsList[2] = _frstPaddle;
            ObjectsList[3] = _scndPaddle;
        }
    }
}
