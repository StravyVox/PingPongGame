using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class SecondPlayer.
    /// Implements the <see cref="PingPongGameClassLibrary.Paddle" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.Paddle" />
    public class SecondPlayer:Paddle
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SecondPlayer"/> class.
        /// </summary>
        /// <param name="positionX">The position x.</param>
        /// <param name="positionY">The position y.</param>
        public SecondPlayer(float positionX, float positionY) : base(positionX, positionY)
        {
            Sprite = @"Textures\platform.png";
        }
    }
}
