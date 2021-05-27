
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class BigPaddleCreator.
    /// Implements the <see cref="PingPongGameClassLibrary.BonusBoxCreator" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.BonusBoxCreator" />
    class BigPaddleCreator :BonusBoxCreator
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BigPaddleCreator"/> class.
        /// </summary>
        public BigPaddleCreator() : base() { }

        /// <summary>
        /// Fabrics the method.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>BonusBox.</returns>
        public override BonusBox FabricMethod(float x, float y)
        {
            return new BigPaddleBonusBox(x, y);
        }
    }
}
