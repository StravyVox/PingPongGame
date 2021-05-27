using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary {
    /// <summary>
    /// Class SpeedBallCreator.
    /// Implements the <see cref="PingPongGameClassLibrary.BonusBoxCreator" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.BonusBoxCreator" />
    class SpeedBallCreator :BonusBoxCreator
    {

        /// <summary>
        /// Fabrics the method.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>BonusBox.</returns>
        public override BonusBox FabricMethod(float x, float y)
        {
            return new SpeedBallBonusBox(x, y);
        }
    }
}
