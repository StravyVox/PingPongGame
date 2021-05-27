using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Windows;
namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class BonusMaker.
    /// </summary>
    public class BonusMaker
    {
        /// <summary>
        /// The main window
        /// </summary>
        private RenderForm _mainWindow;
        /// <summary>
        /// Initializes a new instance of the <see cref="BonusMaker"/> class.
        /// </summary>
        /// <param name="window">The window.</param>
        public BonusMaker(RenderForm window)
        {
            _mainWindow = window;
        }


        /// <summary>
        /// Converts to makeabonus.
        /// </summary>
        /// <returns>BonusBox.</returns>
        public BonusBox ToMakeABonus()
        {
            BonusBox box;
            BonusBoxCreator creator;
            Random randPos = new Random();
            int x = randPos.Next(1,_mainWindow.Size.Width/100)*100;
            int y = randPos.Next(50, _mainWindow.Size.Height - 50);
            int res = randPos.Next(1, 4);
            switch (res)
            {
                case 1:
                    creator = new BigPaddleCreator();
                    box = creator.FabricMethod(x, y);
                    return box;
                case 2:
                    creator = new SmallPaddleCreator();
                    box = creator.FabricMethod(x, y);
                    return box;
                case 3:
                    creator = new SpeedBallCreator();
                    box = creator.FabricMethod(x, y);
                    return box;
            }
            return null;
        }
    }
}
