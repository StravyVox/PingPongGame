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
        FrameDrawer _FrameDrawer;
        RenderForm _mainWindowGame;
        Logic _GameLogic;
        public MainEngine(RenderForm mainForm)
        {
            _mainBall = new Ball();
            _frstPaddle = new Paddle(765,300);
            _scndPaddle = new Paddle(0,300);

            _mainWindowGame = mainForm;
            _FrameDrawer = new FrameDrawer(mainForm, _mainBall, _frstPaddle, _scndPaddle);
            _GameLogic = new Logic(_mainBall, _frstPaddle, _scndPaddle);
            _mainWindowGame = mainForm;
        }
        private void Restart()
        {
            _mainBall = new Ball();
            _frstPaddle = new Paddle(765,300);
            _scndPaddle = new Paddle(0,300);
            
            _GameLogic = new Logic(_mainBall, _frstPaddle, _scndPaddle);
            _FrameDrawer = new FrameDrawer(_mainWindowGame, _mainBall, _frstPaddle, _scndPaddle);
        }
        public void Logic()
        {
            if (_GameLogic._GameIsPlaying == true)
            {
                _GameLogic.GameLogic();
            }
            else Restart();
        }
        public void FrameDraw()
        {
            _FrameDrawer.FrameDraw();
        }
        public void Dispose()
        {
            _FrameDrawer.Dispose();
        }
    }

}
