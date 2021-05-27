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
    /// <summary>
    /// Class ControlersChecker.
    /// </summary>
    public static class ControlersChecker
    {
      

        /// <summary>
        /// Determines whether [is down key pressed] [the specified key to check].
        /// </summary>
        /// <param name="keyToCheck">The key to check.</param>
        /// <returns><c>true</c> if [is down key pressed] [the specified key to check]; otherwise, <c>false</c>.</returns>
        public static bool IsDownKeyPressed(Key keyToCheck)
        {
            return Keyboard.IsKeyDown(keyToCheck);
        }

    }
}
