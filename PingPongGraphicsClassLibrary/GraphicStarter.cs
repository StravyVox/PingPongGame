using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.Direct2D1;
using SharpDX;
using SharpDX.Windows;
using SharpDX.Mathematics.Interop;
namespace PingPongGraphicsClassLibrary
{
    class GraphicStarter:IDisposable
    {
        SharpDX.Direct2D1.RenderTarget _renderTarget = null;
        SharpDX.Direct2D1.Factory _Factory = null;
        public GraphicStarter(RenderForm mainform)
        {
            if (_Factory != null) _Factory.Dispose();
            if (_renderTarget != null) _renderTarget.Dispose();
            Initialize(mainform);
        }
        public SharpDX.Direct2D1.RenderTarget BaseRenderTarget
        {
            get
            {
                return _renderTarget;
            }
            set
            {
                _renderTarget = value;
            }
        }
        protected Factory BaseFactory
        {
            get
            {
                return _Factory;
            }
            set
            {
                _Factory = value;
            }
        }
        public void Initialize(RenderForm mainform)
        {
            _Factory = new Factory(FactoryType.SingleThreaded);
            HwndRenderTargetProperties n = new HwndRenderTargetProperties();
            System.Drawing.Rectangle rect = mainform.DisplayRectangle;
            n.Hwnd = mainform.Handle;
            n.PixelSize = new Size2(mainform.ClientSize.Width, mainform.ClientSize.Height);
            RenderTargetProperties nn = new RenderTargetProperties();
            _renderTarget = new WindowRenderTarget(_Factory, nn, n);
        }
        public void Dispose()
        {
            _renderTarget.Dispose();
            _Factory.Dispose();
        }
    }
}
