using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongGameClassLibrary
{
    /// <summary>
    /// Class DecoratorWorker.
    /// </summary>
    public static class DecoratorWorker
    {
       

        /// <summary>
        /// Converts to returnadecoratorforpaddle.
        /// </summary>
        /// <param name="box">The box.</param>
        /// <param name="paddleToDecorate">The paddle to decorate.</param>
        /// <returns>Paddle.</returns>
        public static Paddle ToReturnADecoratorForPaddle(BonusBox box, Paddle paddleToDecorate)
        {
            
            switch (box.BonusType)
            {
                case "SmallPaddle":
                    SmallPaddleDecorator SmPad = new SmallPaddleDecorator(paddleToDecorate);
                    paddleToDecorate = SmPad.Pad;
                    return paddleToDecorate;
                case "BigPaddle":
                    BigPaddleDecorator BgPad = new BigPaddleDecorator(paddleToDecorate);
                    paddleToDecorate = BgPad.Pad;
                    return paddleToDecorate;
            }
            return null;
        }
        /// <summary>
        /// Converts to returndecoratorforball.
        /// </summary>
        /// <param name="box">The box.</param>
        /// <param name="BallToDecorate">The ball to decorate.</param>
        /// <returns>Ball.</returns>
        public static Ball ToReturnDecoratorForBall(BonusBox box, Ball BallToDecorate)
        {
            switch (box.BonusType)
            {
                case "SpeedBall":
                    SpeedBallDecorator SpBall = new SpeedBallDecorator(BallToDecorate);
                    BallToDecorate = SpBall.Ball;
                    return BallToDecorate;
            }
            return null;
        }
    }
}
