using SharpDX;
using SharpDX.Windows;
using SharpDX.Mathematics.Interop;
namespace PingPongGraphicsClassLibrary
{
    /// <summary>
    /// Class GraphicsDrawer.
    /// Implements the <see cref="PingPongGraphicsClassLibrary.GraphicStarter" />
    /// </summary>
    /// <seealso cref="PingPongGraphicsClassLibrary.GraphicStarter" />
    public class GraphicsDrawer : GraphicStarter
    {
        /// <summary>
        /// The sprite
        /// </summary>
        SpriteSheet _sprite;
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphicsDrawer"/> class.
        /// </summary>
        /// <param name="mainform">The mainform.</param>
        public GraphicsDrawer(RenderForm mainform) :base(mainform)
        {
            _sprite = new SpriteSheet(null, this);
        }
        /// <summary>
        /// Begins the draw.
        /// </summary>
        public void BeginDraw()
        {
            BaseRenderTarget.BeginDraw();
        }
        /// <summary>
        /// Ends the draw.
        /// </summary>
        public void EndDraw()
        {
            BaseRenderTarget.EndDraw();
        }
        /// <summary>
        /// Clears the screen.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        public void ClearScreen(float r, float g, float b)
        {
            BaseRenderTarget.Clear(new Color4(r, g, b, 0.1f));
        }
        /// <summary>
        /// Draws the sprite.
        /// </summary>
        /// <param name="spriteInfo">The sprite information.</param>
        /// <param name="xpos">The xpos.</param>
        /// <param name="ypos">The ypos.</param>
        /// <param name="scale">The scale.</param>
        public void DrawSprite(string spriteInfo, float xpos, float ypos, float scale = 1)
        {
            _sprite.Filename = spriteInfo;
            SharpDX.Direct2D1.Bitmap imageInBitmap = _sprite.ToReturnABitmap();
            RawRectangleF size = new RawRectangleF(0.0f,0.0f, imageInBitmap.Size.Height, imageInBitmap.Size.Width);
            BaseRenderTarget.DrawBitmap(imageInBitmap, new RawRectangleF(xpos, ypos, xpos + imageInBitmap.Size.Width/scale, ypos + imageInBitmap.Size.Height/scale), 1.0f, SharpDX.Direct2D1.BitmapInterpolationMode.Linear, size);
            imageInBitmap.Dispose();
        }
        /// <summary>
        /// Draws the score.
        /// </summary>
        /// <param name="score">The score.</param>
        /// <param name="xpos">The xpos.</param>
        public void DrawScore(int score, int xpos)
        {
            RawRectangleF rectangle2 = new RectangleF(xpos, 0, 200, 200);
            SharpDX.Direct2D1.SolidColorBrush brush = new SharpDX.Direct2D1.SolidColorBrush(BaseRenderTarget, new Color(150, 10, 10));
            BaseRenderTarget.DrawText(score.ToString(), TextForm, rectangle2,brush);
        }
    }
} 
