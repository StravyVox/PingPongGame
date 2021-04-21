using SharpDX;
using SharpDX.Windows;
using SharpDX.Mathematics.Interop;
namespace PingPongGraphicsClassLibrary
{
    class GraphicsDrawer : GraphicStarter
    {
        SpriteSheet sprite;
        public GraphicsDrawer(RenderForm mainform) :base(mainform)
        {
            sprite = new SpriteSheet(null, this);
        }
        public void BeginDraw()
        {
            BaseRenderTarget.BeginDraw();
        }
        public void EndDraw()
        {
            BaseRenderTarget.EndDraw();
        }
        public void ClearScreen(float r, float g, float b)
        {
            BaseRenderTarget.Clear(new Color4(r, g, b, 0.1f));
        }
        public void DrawSprite(string spriteInfo, float xpos, float ypos, int scale = 1)
        {
            sprite.Filename = spriteInfo;
            SharpDX.Direct2D1.Bitmap imageInBitmap = sprite.ToReturnABitmap();
            RawRectangleF size = new RawRectangleF(0.0f,0.0f, imageInBitmap.Size.Height, imageInBitmap.Size.Width);
            BaseRenderTarget.DrawBitmap(imageInBitmap, new RawRectangleF(xpos, ypos, xpos + imageInBitmap.Size.Width/scale, ypos + imageInBitmap.Size.Height/scale), 1.0f, SharpDX.Direct2D1.BitmapInterpolationMode.Linear, size);
            imageInBitmap.Dispose();
        }
    }
} 
