using System;
using SharpDX.Windows;
namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class GameWindow.
    /// </summary>
    public class GameWindow
    {
        /// <summary>
        /// The window
        /// </summary>
        RenderForm _window;
        /// <summary>
        /// Initializes a new instance of the <see cref="GameWindow"/> class.
        /// </summary>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        public GameWindow(int Width, int Height)
        {
            _window = new RenderForm("Ping Pong");
            _window.Width = Width;
            _window.Height = Height;
            _window.AllowUserResizing = false;
        }
        /// <summary>
        /// Gets the window.
        /// </summary>
        /// <value>The window.</value>
        public RenderForm Window
        {
            get
            {
                return _window;
            }
        }

  
    }
}
