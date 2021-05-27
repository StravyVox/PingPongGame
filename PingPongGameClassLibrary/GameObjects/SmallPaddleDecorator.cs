using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class SmallPaddleDecorator.
    /// Implements the <see cref="PingPongGameClassLibrary.PaddleDecorator" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.PaddleDecorator" />
    class SmallPaddleDecorator : PaddleDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmallPaddleDecorator"/> class.
        /// </summary>
        /// <param name="PaddleToDecorate">The paddle to decorate.</param>
        public SmallPaddleDecorator(Paddle PaddleToDecorate) : base(PaddleToDecorate)
        {
            PaddleToDecorate.Height /= 2;
            PaddleToDecorate.Width /= 2;
            PaddleToDecorate.Scale *=1.5f;
        }
    }

}
