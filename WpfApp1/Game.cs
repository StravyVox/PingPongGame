using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Windows;
using SharpDX.Direct3D;
using SharpDX.Direct2D1;
using SharpDX;
namespace WpfApp1
{
    class Game
    {
        GameWindow _mainGameWindow;
        MainEngine Engine;
        public Game()
        {
            _mainGameWindow = new GameWindow(800, 600);
            Engine = new MainEngine(_mainGameWindow.Window);
        }
        public void RenderCallback()
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
