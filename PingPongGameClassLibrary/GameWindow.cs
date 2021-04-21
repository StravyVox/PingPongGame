using System;
using SharpDX.Windows;
namespace PingPongGameClassLibrary
{
    class GameWindow
    {
        RenderForm _window;
        public GameWindow(int Width, int Height)
        {
            _window = new RenderForm("Ping Pong");
            _window.Width = Width;
            _window.Height = Height;
            _window.AllowUserResizing = false;
        }
        public RenderForm Window
        {
            get
            {
                return _window;
            }
        } 
    }
}
