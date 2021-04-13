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
    class Graphics:SharpDX.Windows.RenderForm
    {
        SharpDX.Direct2D1.RenderTarget _renderTarget = null;
        SharpDX.Direct2D1.Factory _Factory = null;
        public Graphics()
        {
            if (_Factory!=null) _Factory.Dispose();
            if (_renderTarget != null) _renderTarget.Dispose();
        }
        public bool Initialize(RenderForm mainform)
        {
            _Factory = new Factory(FactoryType.SingleThreaded);
            HwndRenderTargetProperties n = new HwndRenderTargetProperties();
            System.Drawing.Rectangle rect = mainform.DisplayRectangle;
            n.Hwnd = mainform.Handle;
            n.PixelSize = new Size2 (mainform.ClientSize.Width,mainform.ClientSize.Height);
            RenderTargetProperties nn = new RenderTargetProperties();
            _renderTarget = new WindowRenderTarget(_Factory, nn, n);
            return false;
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
        public void DrawBall()
        {
            Ball mainBall = new Ball();
            mainBall.Draw(_renderTarget);
        }
    }
}
