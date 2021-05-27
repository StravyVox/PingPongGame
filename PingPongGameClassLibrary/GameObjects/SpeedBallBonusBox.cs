using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class SpeedBallBonusBox.
    /// Implements the <see cref="PingPongGameClassLibrary.BonusBox" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.BonusBox" />
    public class SpeedBallBonusBox:BonusBox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedBallBonusBox"/> class.
        /// </summary>
        /// <param name="posX">The position x.</param>
        /// <param name="posY">The position y.</param>
        public SpeedBallBonusBox(float posX, float posY) : base(posX, posY, "SpeedBall") { }
    }
}
