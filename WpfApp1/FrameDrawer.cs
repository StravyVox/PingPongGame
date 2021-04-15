using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Windows;
namespace WpfApp1
{
    class FrameDrawer: IDisposable
    {
        Ball _mainBall;
        Paddle _frstPaddle;
        Paddle _scndPaddle;
        GraphicEngine _GraphicEngine;
        public FrameDrawer(RenderForm mainForm, Ball mainBall,Paddle frstPaddle,Paddle scndPaddle)
        {   
            _mainBall = mainBall;
            _frstPaddle = frstPaddle;
            _scndPaddle = scndPaddle;
            _GraphicEngine = new GraphicEngine();
            _GraphicEngine.Initialize(mainForm);
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
        public void Dispose()
        {
            _GraphicEngine.Dispose();
        }
    }
}
