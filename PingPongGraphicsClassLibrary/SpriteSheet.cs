using System;
using SharpDX.WIC;
namespace PingPongGraphicsClassLibrary
{
    /// <summary>
    /// Class SpriteSheet.
    /// Implements the <see cref="System.IDisposable" />
    /// </summary>
    /// <seealso cref="System.IDisposable" />
   public class SpriteSheet :IDisposable
    {
        /// <summary>
        /// The graph engine
        /// </summary>
        GraphicsDrawer _GraphEngine;
        /// <summary>
        /// The filename
        /// </summary>
        string _filename;
        /// <summary>
        /// The direct2 d bit map
        /// </summary>
        SharpDX.Direct2D1.Bitmap Direct2DBitMap;
        /// <summary>
        /// The wic factory
        /// </summary>
        ImagingFactory _wicFactory;
        /// <summary>
        /// The wic decoder
        /// </summary>
        BitmapDecoder _wicDecoder;
        /// <summary>
        /// The frame decoder
        /// </summary>
        BitmapFrameDecode _FrameDecoder;
        /// <summary>
        /// The wic to direct converter
        /// </summary>
        FormatConverter _WicToDirectConverter;
        /// <summary>
        /// Initializes a new instance of the <see cref="SpriteSheet"/> class.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="GraphEngine">The graph engine.</param>
        public SpriteSheet(string filename, GraphicsDrawer GraphEngine)
        {
            _GraphEngine = GraphEngine;
            _filename = filename;

        }
        /// <summary>
        /// Sets the filename.
        /// </summary>
        /// <value>The filename.</value>
        public string Filename
        {
            set
            {
                _filename = value;
            }
            get
            {
                return _filename;
            }
        }

     

        /// <summary>
        /// Converts to returnabitmap.
        /// </summary>
        /// <returns>SharpDX.Direct2D1.Bitmap.</returns>
        public SharpDX.Direct2D1.Bitmap ToReturnABitmap()
        {
            _wicFactory = new ImagingFactory();
            _wicDecoder = new BitmapDecoder(_wicFactory, _filename, SharpDX.IO.NativeFileAccess.Read, DecodeOptions.CacheOnLoad);
            
            _FrameDecoder = _wicDecoder.GetFrame(0);

            _WicToDirectConverter = new FormatConverter(_wicFactory);
            _WicToDirectConverter.Initialize(_FrameDecoder, SharpDX.WIC.PixelFormat.Format32bppPBGRA, BitmapDitherType.None, null, 0.0,BitmapPaletteType.Custom);

            Direct2DBitMap =  SharpDX.Direct2D1.Bitmap.FromWicBitmap(_GraphEngine.BaseRenderTarget, _WicToDirectConverter);
           
            _wicFactory.Dispose();
            _wicDecoder.Dispose();
            _WicToDirectConverter.Dispose();
            return Direct2DBitMap; 
        }
        /// <summary>
        /// Выполняет определяемые приложением задачи, связанные с удалением, высвобождением или сбросом неуправляемых ресурсов.
        /// </summary>
        public void Dispose()
        {
            _GraphEngine.Dispose();
            
        }
    }
}
