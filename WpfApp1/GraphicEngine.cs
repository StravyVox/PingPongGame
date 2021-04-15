using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;
using SharpDX.Direct2D1;
using SharpDX;
using SharpDX.Windows;

namespace WpfApp1
{

    class GraphicEngine:IDisposable
    {
        SharpDX.Direct2D1.RenderTarget _renderTarget = null;
        SharpDX.Direct2D1.Factory _Factory = null;
        public GraphicEngine()
        {
            if (_Factory!=null) _Factory.Dispose();
            if (_renderTarget != null) _renderTarget.Dispose();
        }
        public void Initialize(RenderForm mainform)
        {
            _Factory = new Factory(FactoryType.SingleThreaded);
            HwndRenderTargetProperties n = new HwndRenderTargetProperties();
            System.Drawing.Rectangle rect = mainform.DisplayRectangle;
            n.Hwnd = mainform.Handle;
            n.PixelSize = new Size2 (mainform.ClientSize.Width,mainform.ClientSize.Height);
            RenderTargetProperties nn = new RenderTargetProperties();
            _renderTarget = new WindowRenderTarget(_Factory, nn, n);
        }
        public void BeginDraw()
        {
            _renderTarget.BeginDraw();
        }
        public void EndDraw()
        {
            _renderTarget.EndDraw();
        }
        public void ClearScreen(float r, float g, float b)
        {
            _renderTarget.Clear(new Color4(r, g, b, 0.1f));
        } 
        public void DrawBall(Ball mainBall)
        {
                SharpDX.Mathematics.Interop.RawVector2 mainPos = new SharpDX.Mathematics.Interop.RawVector2(mainBall.positionX,mainBall.positionY);
                SharpDX.Direct2D1.Ellipse ellipseBall = new Ellipse(mainPos, 10, 10);
                SharpDX.Direct2D1.SolidColorBrush yellowBrush = new SharpDX.Direct2D1.SolidColorBrush(_renderTarget, SharpDX.Color.Yellow);
                 _renderTarget.FillEllipse(ellipseBall, yellowBrush);
        }
        public void DrawPaddle(Paddle paddle )
        {
            SharpDX.RectangleF rectangle1 = new SharpDX.RectangleF(
                paddle.positionX, paddle.positionY,
                paddle.PaddleWidth, paddle.PaddleHeight);
            SharpDX.Direct2D1.SolidColorBrush orangeBrush = new SharpDX.Direct2D1.SolidColorBrush(_renderTarget, SharpDX.Color.Red);
            _renderTarget.FillRectangle(rectangle1, orangeBrush);

        }
        public void Dispose()
        {
            _renderTarget.Dispose();
            _Factory.Dispose();
           
        }
    }
}
