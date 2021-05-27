using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class Paddle.
    /// Implements the <see cref="PingPongGameClassLibrary.GameObject" />
    /// </summary>
    /// <seealso cref="PingPongGameClassLibrary.GameObject" />
    public abstract class Paddle : GameObject
    {
        /// <summary>
        /// The paddle width
        /// </summary>
        private int PaddleWidth;
        /// <summary>
        /// The paddle height
        /// </summary>
        private int PaddleHeight;
        /// <summary>
        /// The score
        /// </summary>
        private int _score;
        /// <summary>
        /// Initializes a new instance of the <see cref="Paddle"/> class.
        /// </summary>
        /// <param name="positionX">The position x.</param>
        /// <param name="positionY">The position y.</param>
        /// <param name="texturefile">The texturefile.</param>
        /// <param name="Paddlewidth">The paddlewidth.</param>
        /// <param name="Paddleheight">The paddleheight.</param>
        public Paddle(float positionX, float positionY, string texturefile = @"Textures\platform.png", int Paddlewidth = 20, int Paddleheight = 80) : base(positionX, positionY, texturefile)
        {
            PaddleWidth = Paddlewidth;
            PaddleHeight = Paddleheight;
            _score = 0;
            Scale = 5;
        }
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        public int Width
        {
            get
            {
                return PaddleWidth;
            }
            set
            {
                PaddleWidth = value;
            }
        }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public int Height
        {
            get
            {
                return PaddleHeight;
            }
            set
            {
                PaddleHeight = value;
            }
        }

        /// <summary>
        /// Gets or sets the score.
        /// </summary>
        /// <value>The score.</value>
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }
        /// <summary>
        /// Moves to position.
        /// </summary>
        /// <param name="speedY">The speed y.</param>
        /// <param name="resolutionY">The resolution y.</param>
        public void MoveToPosition(int speedY, int resolutionY)
        {
            Ypos += speedY;
            if (Ypos < 0)
            {
                Ypos = PaddleHeight / 10;
            }
            if (Ypos + PaddleHeight >= resolutionY)
            {
                Ypos = resolutionY - PaddleHeight;
            }
        }
        /// <summary>
        /// Adds the score.
        /// </summary>
        public void AddScore()
        {
            _score++;
        }
    }
}
