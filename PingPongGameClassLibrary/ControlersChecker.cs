using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.IO;
using System.Windows.Input;
using System.Windows.Forms;
namespace PingPongGameClassLibrary
{
    class ControlersChecker
    {
        public ControlersChecker()
        {
           
        }
        public bool IsDownKeyPressed(Key keyToCheck)
        {
            return Keyboard.IsKeyDown(keyToCheck);
        }
        public float Ypos()
        {
            return System.Windows.Forms.Cursor.Position.Y;
        }

    }
}
