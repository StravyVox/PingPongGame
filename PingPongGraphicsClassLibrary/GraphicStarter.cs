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
    /// <summary>
    /// Class GraphicStarter.
    /// Implements the <see cref="System.IDisposable" />
    /// </summary>
    /// <seealso cref="System.IDisposable" />
   public class GraphicStarter :IDisposable
    {
        /// <summary>
        /// The render target
        /// </summary>
        SharpDX.Direct2D1.RenderTarget _renderTarget;
        /// <summary>
        /// The factory
        /// </summary>
        SharpDX.Direct2D1.Factory _Factory;
        /// <summary>
        /// The direct write factory
        /// </summary>
        SharpDX.DirectWrite.Factory _DirectWriteFactory;
        /// <summary>
        /// The text form
        /// </summary>
        SharpDX.DirectWrite.TextFormat _TextForm;
        /// <summary>
        /// The render form
        /// </summary>
        RenderForm _renderForm;
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphicStarter"/> class.
        /// </summary>
        /// <param name="mainform">The mainform.</param>
        public GraphicStarter(RenderForm mainform)
        {
            if (_Factory != null) _Factory.Dispose();
            if (_renderTarget != null) _renderTarget.Dispose();
            _renderForm = mainform;
            Initialize(_renderForm);
        }
        /// <summary>
        /// Gets or sets the base render target.
        /// </summary>
        /// <value>The base render target.</value>
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
        /// <summary>
        /// Gets or sets the base factory.
        /// </summary>
        /// <value>The base factory.</value>
        public Factory BaseFactory
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
        /// <summary>
        /// Gets the direct factory.
        /// </summary>
        /// <value>The direct factory.</value>
        public SharpDX.DirectWrite.Factory DirectFactory
        {
            get
            {
                return _DirectWriteFactory;
            }
        }
        /// <summary>
        /// Gets the text form.
        /// </summary>
        /// <value>The text form.</value>
        protected SharpDX.DirectWrite.TextFormat TextForm
        {
            get
            {
                return _TextForm;
            }
        }
        /// <summary>
        /// Gets the main form.
        /// </summary>
        /// <value>The main form.</value>
        public RenderForm MainForm
        {
            get
            {
                return _renderForm;
            }
            
        }


        /// <summary>
        /// Initializes the specified mainform.
        /// </summary>
        /// <param name="mainform">The mainform.</param>
        public void Initialize(RenderForm mainform)
        {
            _Factory = new Factory(FactoryType.SingleThreaded);
            HwndRenderTargetProperties HoldWindowProp = new HwndRenderTargetProperties();
            HoldWindowProp.Hwnd = mainform.Handle;
            HoldWindowProp.PixelSize = new Size2(mainform.ClientSize.Width, mainform.ClientSize.Height);
            RenderTargetProperties RenderProperties = new RenderTargetProperties();
            _renderTarget = new WindowRenderTarget(_Factory, RenderProperties, HoldWindowProp);
            _DirectWriteFactory = new SharpDX.DirectWrite.Factory();
            _TextForm = new SharpDX.DirectWrite.TextFormat(_DirectWriteFactory, "Verdana", 50);
            _TextForm.TextAlignment = SharpDX.DirectWrite.TextAlignment.Center;
            _TextForm.ParagraphAlignment = SharpDX.DirectWrite.ParagraphAlignment.Center;
                }
        /// <summary>
        /// Выполняет определяемые приложением задачи, связанные с удалением, высвобождением или сбросом неуправляемых ресурсов.
        /// </summary>
        public void Dispose()
        {
            _renderTarget.Dispose();
            _Factory.Dispose();
        }
    }
}
