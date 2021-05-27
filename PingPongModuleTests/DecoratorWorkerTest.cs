using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class DecoratorWorkerTest.
    /// </summary>
    [TestClass]
    public class DecoratorWorkerTest
    {
        /// <summary>
        /// Defines the test method TestDecoratorPaddle.
        /// </summary>
        [TestMethod]
        public void TestDecoratorPaddle()
        {
            BigPaddleBonusBox bigPaddleBox = new BigPaddleBonusBox(100, 100);
            FirstPlayer paddleToDecorate = new FirstPlayer(100, 100);
            paddleToDecorate = (FirstPlayer) DecoratorWorker.ToReturnADecoratorForPaddle(bigPaddleBox, paddleToDecorate);
            bool result = false; 
            if (paddleToDecorate.Scale == 5 * 0.6f)
            {
                result = true;
            }
            Assert.AreEqual(true, result);
        }
        /// <summary>
        /// Defines the test method TestDecoratorBall.
        /// </summary>
        [TestMethod]
        public void TestDecoratorBall()
        {
            SpeedBallBonusBox speedBallBox = new SpeedBallBonusBox(100, 100);
            Ball ballToDecorate = new Ball();
            float speedX = ballToDecorate.SpeedX;
            ballToDecorate = (Ball)DecoratorWorker.ToReturnDecoratorForBall(speedBallBox, ballToDecorate);
            bool result = false;
            if (ballToDecorate.SpeedX == speedX*2)
            {
                result = true;
            }
            Assert.AreEqual(true, result);
        }
      
    }
}
