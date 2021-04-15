using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace WpfApp1
{
    class Logic
    {
        public bool _GameIsPlaying;
        Ball _mainBall;
        Paddle _frstPaddle;
        Paddle _scndPaddle;
        ControlersWorking _ControllerHelper;
        public Logic(Ball ball, Paddle frstPaddle, Paddle scndPaddle)
        {
            _mainBall = ball;
            _frstPaddle = frstPaddle;
            _scndPaddle = scndPaddle;
            _GameIsPlaying = true;
            _ControllerHelper = new ControlersWorking();
        }
        public void GameLogic()
        {
        
                _mainBall.Advance();

                _frstPaddle.MoveToPosition((int)_ControllerHelper.Ypos());

                _scndPaddle.MoveToPosition((int)_ControllerHelper.Ypos());

                if (Keyboard.IsKeyDown(Key.Space) == true)
                {
                    _mainBall.Bust();
                }

                _mainBall.CheckHitRightPaddle(_frstPaddle.positionY);
                _mainBall.CheckHitLeftPaddle(_scndPaddle.positionY);
                if (_mainBall.IsOutsideLeft())
                {
                    _GameIsPlaying = false;
                    _scndPaddle.IncreaseScore();
                }
                if (_mainBall.IsOutsideRight())
                {
                    _GameIsPlaying = false;
                    _frstPaddle.IncreaseScore();
                }
            
            
        }
    }
}
