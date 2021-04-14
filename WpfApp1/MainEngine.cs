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
namespace WpfApp1
{
    class MainEngine:IDisposable
    {
        Ball _mainBall;
        Paddle _frstPaddle;
        Paddle _scndPaddle;
        Graphics _GraphicEngine;
        RenderForm _mainWindowGame;
        bool _playing;
        public MainEngine(RenderForm mainForm)
        {
            _mainBall = new Ball();
            _GraphicEngine = new Graphics();
            _frstPaddle = new Paddle(765,300);
            _scndPaddle = new Paddle(0,300);
            _mainWindowGame = mainForm;
            _playing = true;
            _GraphicEngine.Initialize(_mainWindowGame);

        }

        private void Restart()
        {
            _mainBall = new Ball();
            _frstPaddle = new Paddle(765,300);
            _scndPaddle = new Paddle(0,300);
            _playing = true;

        }
        public void Logic()
        {
            if (_playing == true)
            {
                
                _mainBall.Advance();

                _frstPaddle.MoveToPosition((int)Ypos());

                _scndPaddle.MoveToPosition((int)Ypos());

                if (Keyboard.IsKeyDown(Key.Space) == true)
                {
                    _mainBall.Bust();
                }

                _mainBall.CheckHitRightPaddle(_frstPaddle.positionY);
                _mainBall.CheckHitLeftPaddle(_scndPaddle.positionY);
                if (_mainBall.IsOutsideLeft())
                {
                    _playing = false;
                    _scndPaddle.IncreaseScore();
                }
                if (_mainBall.IsOutsideRight())
                {
                    _playing = false;
                    _frstPaddle.IncreaseScore();
                }
            }
            else
            {
                Restart();
            }
        }
        public void FrameDraw()
        {
            
            _GraphicEngine.BeginDraw();
            _GraphicEngine.ClearScreen(0.2f, 0.4f, 0.5f);
            _GraphicEngine.DrawBall(_mainBall);
            _GraphicEngine.DrawPaddle(_scndPaddle);
            _GraphicEngine.DrawPaddle(_frstPaddle);
            _GraphicEngine.EndDraw();
        }
        public void Reset()
        {
            _mainBall.Reset();
        }
        public float Ypos()
        {
            
            return System.Windows.Forms.Cursor.Position.Y;
        }
 
        public void Dispose()
        {
            _GraphicEngine.Dispose();
        }
    }

}
