using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;
using SharpDX.WIC;
using SharpDX.Direct2D1;
using SharpDX.IO;
using SharpDX.DXGI;
using SharpDX.Mathematics.Interop;
namespace PingPongGraphicsClassLibrary
{
    class SpriteSheet:IDisposable
    {
        GraphicsDrawer _GraphEngine;
        string _filename;
        SharpDX.Direct2D1.Bitmap Direct2DBitMap;
        ImagingFactory wicFactory;
        BitmapDecoder wicDecoder;
        BitmapFrameDecode FrameDecoder;
        FormatConverter WicToDirectConverter;
        public SpriteSheet(string filename, GraphicsDrawer GraphEngine)
        {
            _GraphEngine = GraphEngine;
            _filename = filename;
        }
        public string Filename
        {
            set
            {
                _filename = value;
            }
        }
        public SharpDX.Direct2D1.Bitmap ToReturnABitmap()
        {
            wicFactory = new ImagingFactory();
            wicDecoder = new BitmapDecoder(wicFactory, _filename, SharpDX.IO.NativeFileAccess.Read, DecodeOptions.CacheOnLoad);
            
            FrameDecoder = wicDecoder.GetFrame(0);

            WicToDirectConverter = new FormatConverter(wicFactory);

            //Setup the converter 
            WicToDirectConverter.Initialize(FrameDecoder, SharpDX.WIC.PixelFormat.Format32bppPBGRA, BitmapDitherType.None, null, 0.0,BitmapPaletteType.Custom);

            //use  to create bitmap

            Direct2DBitMap =  SharpDX.Direct2D1.Bitmap.FromWicBitmap(_GraphEngine.BaseRenderTarget, WicToDirectConverter);
           
            wicFactory.Dispose();
            wicDecoder.Dispose();
            WicToDirectConverter.Dispose();
            return Direct2DBitMap; 
        }
        public void Dispose()
        {
            _GraphEngine.Dispose();
            wicFactory.Dispose();
            wicDecoder.Dispose();
            WicToDirectConverter.Dispose();
            FrameDecoder.Dispose();
        }
    }
}
