using SharpDX.Windows;
namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class Game.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The main game window
        /// </summary>
        GameWindow _mainGameWindow;
        /// <summary>
        /// The engine
        /// </summary>
        MainEngine Engine;
        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        public Game()
        {
            _mainGameWindow = new GameWindow(800, 600);
            Engine = new MainEngine(_mainGameWindow.Window);
        }
        /// <summary>
        /// Renders the callback.
        /// </summary>
        private void RenderCallback()
        {
            Engine.Logic();
            Engine.FrameDraw();
        }
        /// <summary>
        /// Runs this instance.
        /// </summary>
        public void Run()
        {
            RenderLoop.Run(_mainGameWindow.Window, RenderCallback);
        }
    }
}
    