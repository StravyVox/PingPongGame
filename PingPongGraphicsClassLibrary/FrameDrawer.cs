using System;
using SharpDX.Windows;
namespace PingPongGraphicsClassLibrary
{
    public class FrameDrawer : IDisposable
    {
        GraphicsDrawer _GraphicEngine;
        public FrameDrawer(RenderForm mainform)
        {
            _GraphicEngine = new GraphicsDrawer(mainform);
        }
        public void FrameDraw(string[] _sprites,float[] _xPos, float[] _yPos)
        {
            int[] scales = new int[4] { 1, 18, 5, 5 };
            _GraphicEngine.BeginDraw();
            _GraphicEngine.ClearScreen(0.2f, 0.4f, 0.5f);
            for (int i = 0; i < _sprites.Length; i++)
            {
                _GraphicEngine.DrawSprite(_sprites[i], _xPos[i], _yPos[i], scales[i]);
            }
            _GraphicEngine.EndDraw();
        }
        public void Dispose()
        {
            _GraphicEngine.Dispose();
        }
    }
}


