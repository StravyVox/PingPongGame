using System;
using SharpDX.Windows;
namespace PingPongGraphicsClassLibrary
{
    /// <summary>
    /// Class FrameDrawer.
    /// Implements the <see cref="System.IDisposable" />
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class FrameDrawer : IDisposable
    {
        /// <summary>
        /// The graphic engine
        /// </summary>
        GraphicsDrawer _GraphicEngine;
        /// <summary>
        /// Initializes a new instance of the <see cref="FrameDrawer"/> class.
        /// </summary>
        /// <param name="mainform">The mainform.</param>
        public FrameDrawer(RenderForm mainform)
        {
            _GraphicEngine = new GraphicsDrawer(mainform);
        }
        /// <summary>
        /// Spriteses the draw.
        /// </summary>
        /// <param name="_sprites">The sprites.</param>
        /// <param name="_xPos">The x position.</param>
        /// <param name="_yPos">The y position.</param>
        /// <param name="scales">The scales.</param>
        public void SpritesDraw(string[] _sprites,float[] _xPos, float[] _yPos, float[]scales)
        {
            _GraphicEngine.BeginDraw();
            _GraphicEngine.ClearScreen(0.2f, 0.4f, 0.5f);
            for (int i = 0; i < _sprites.Length; i++)
            {
                _GraphicEngine.DrawSprite(_sprites[i], _xPos[i], _yPos[i], scales[i]);
            }  
            _GraphicEngine.EndDraw();
        }
        /// <summary>
        /// Scores the draw.
        /// </summary>
        /// <param name="scorefrst">The scorefrst.</param>
        /// <param name="scorescnd">The scorescnd.</param>
        public void ScoreDraw(int scorefrst, int scorescnd)
        {
            _GraphicEngine.BeginDraw();
            _GraphicEngine.DrawScore(scorefrst, _GraphicEngine.MainForm.Width/100);
            _GraphicEngine.DrawScore(scorescnd, (_GraphicEngine.MainForm.Width-(_GraphicEngine.MainForm.Width/4)));
            _GraphicEngine.EndDraw();
        }
        /// <summary>
        /// Выполняет определяемые приложением задачи, связанные с удалением, высвобождением или сбросом неуправляемых ресурсов.
        /// </summary>
        public void Dispose()
        {
            _GraphicEngine.Dispose();
        }
    }
}


