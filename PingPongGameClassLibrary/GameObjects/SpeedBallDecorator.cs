using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class SpeedBallDecorator.
    /// Implements the <see cref="PingPongGameClassLibrary.BallDecorator" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.BallDecorator" />
    public class SpeedBallDecorator:BallDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedBallDecorator"/> class.
        /// </summary>
        /// <param name="BallToDecorate">The ball to decorate.</param>
        public SpeedBallDecorator(Ball BallToDecorate) : base(BallToDecorate)
        {
            BallToDecorate.SpeedX *= 2;
            BallToDecorate.SpeedY *= 2;
        }

        
    }
}
