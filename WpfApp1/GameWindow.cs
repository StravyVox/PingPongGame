using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Windows;
using SharpDX.Direct3D;
using SharpDX.Direct2D1;
namespace WpfApp1
{
    class GameWindow
    {
        RenderForm _window;
        public GameWindow(int Width, int Height)
        {
            _window = new RenderForm("Pong");
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
