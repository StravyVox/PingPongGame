using SharpDX.Windows;
namespace PingPongGameClassLibrary
{
    public class Game
    {
        GameWindow _mainGameWindow;
        MainEngine Engine;
        public Game()
        {
            _mainGameWindow = new GameWindow(800, 600);
            Engine = new MainEngine(_mainGameWindow.Window);
        }
        private void RenderCallback()
        {
            Engine.Logic();
            Engine.FrameDraw();
        }
        public void Run()
        {
            RenderLoop.Run(_mainGameWindow.Window, RenderCallback);
        }
    }
}
