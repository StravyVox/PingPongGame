
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SharpDX;
using SharpDX.Windows;
namespace PingPongGame
{
    class Core
    {
        RenderForm window;

        public Core()
        {
            window = new RenderForm("SharpDX Tutorial 0");
        }

        public void Run()
        {
            RenderLoop.Run(window, RenderCallback);
        }

        public void RenderCallback()
        {

        }
    }
}
