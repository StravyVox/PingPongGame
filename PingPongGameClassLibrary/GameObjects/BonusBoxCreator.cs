using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class BonusBoxCreator.
    /// </summary>
    public abstract class BonusBoxCreator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BonusBoxCreator"/> class.
        /// </summary>
        public BonusBoxCreator() { }
        /// <summary>
        /// Fabrics the method.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>BonusBox.</returns>
        public abstract BonusBox FabricMethod(float x, float y);
    }
}
