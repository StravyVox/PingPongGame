using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{

    /// <summary>
    /// Class BallDecorator.
    /// Implements the <see cref="PingPongGameClassLibrary.Ball" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.Ball" />
    abstract public class BallDecorator : Ball
    {
        /// <summary>
        /// The main ball
        /// </summary>
        protected Ball _mainBall;

        /// <summary>
        /// Initializes a new instance of the <see cref="BallDecorator"/> class.
        /// </summary>
        /// <param name="BallToDecorate">The ball to decorate.</param>
        public BallDecorator(Ball BallToDecorate) : base()
        {
            _mainBall = BallToDecorate;
        }
        /// <summary>
        /// Gets the ball.
        /// </summary>
        /// <value>The ball.</value>
        public Ball Ball
        {
            get
            {
                return _mainBall;
            }

        }
    }
}
