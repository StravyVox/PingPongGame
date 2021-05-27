using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class PaddleDecorator.
    /// Implements the <see cref="PingPongGameClassLibrary.Paddle" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.Paddle" />
    abstract class PaddleDecorator:Paddle
    {
        /// <summary>
        /// The main paddle
        /// </summary>
        protected Paddle _mainPaddle;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaddleDecorator"/> class.
        /// </summary>
        /// <param name="paddleToDecorate">The paddle to decorate.</param>
        public PaddleDecorator(Paddle paddleToDecorate) : base(paddleToDecorate.Xpos, paddleToDecorate.Ypos)
        {
            _mainPaddle = paddleToDecorate;
        }
        /// <summary>
        /// Gets the pad.
        /// </summary>
        /// <value>The pad.</value>
        public Paddle Pad
        {
            get
            {
                return _mainPaddle;
            }

        }
    }
}
