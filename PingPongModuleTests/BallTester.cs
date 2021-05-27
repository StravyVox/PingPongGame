using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class BallTester.
    /// </summary>
    [TestClass]
    public class BallTester
    {
        /// <summary>
        /// The ball to test
        /// </summary>
        Ball _BallToTest = new Ball();
        /// <summary>
        /// Defines the test method TestOutsideLeft.
        /// </summary>
        [TestMethod]
        public void TestOutsideLeft()
        {
            _BallToTest.Xpos = 150;
            _BallToTest.Ypos = 150;
            Assert.AreEqual(false, _BallToTest.IsOutsideLeft());
        }
        /// <summary>
        /// Defines the test method TestOutSideRight.
        /// </summary>
        [TestMethod]
        public void TestOutSideRight()
        {
            _BallToTest.Xpos = 150;
            _BallToTest.Ypos = 150;
            Assert.AreEqual(false, _BallToTest.IsOutsideRight(600));
        }
        /// <summary>
        /// Defines the test method TestCheckHitBonusBox.
        /// </summary>
        [TestMethod]
        public void TestCheckHitBonusBox()
        {
            BigPaddleBonusBox bonusBox = new BigPaddleBonusBox(150, 150);
            _BallToTest.Xpos = 150;
            _BallToTest.Ypos = 150;
            Assert.AreEqual(true, _BallToTest.CheckHitBonusBox(bonusBox));
        }
        /// <summary>
        /// Defines the test method TestFrameLogic.
        /// </summary>
        [TestMethod]
        public void TestFrameLogic()
        {
            _BallToTest.SpeedX = 100;
            _BallToTest.SpeedY = 0;
            _BallToTest.Xpos = 150;
            _BallToTest.Ypos = 850;
            _BallToTest.FrameLogic(800);
            Assert.AreEqual(150+(100*0.03f), _BallToTest.Xpos);
        }
        [TestMethod]
        public void TestCheckHitLeft()
        {
            FirstPlayer PaddleToTest = new FirstPlayer(0, 110);
            _BallToTest.Xpos = 17;
            _BallToTest.Ypos = 121;
            _BallToTest.SpeedX = -200;
            bool result = true;
            try
            {
                _BallToTest.CheckHitLeftPaddle(PaddleToTest);
            }
            catch
            {
                result = false;
            }
            finally
            {
                Assert.IsTrue(result);
            }
        }
        [TestMethod]
        public void TestCheckHitRight()
        {
            FirstPlayer PaddleToTest = new FirstPlayer(765, 250);
            _BallToTest.Xpos = 736;
            _BallToTest.Ypos = 257;
            _BallToTest.SpeedX = 400;
            bool result = true;
            try
            {
                _BallToTest.CheckHitRightPaddle(PaddleToTest, 600);
            }
            catch
            {
                result = false;
            }
            finally
            {
                Assert.IsTrue(result);
            }
        }
        [TestMethod]
        public void TestReset()
        {
            _BallToTest.Reset();
            Assert.AreEqual(100, _BallToTest.Xpos);
        }
        [TestMethod]
        public void TestResetWithPlayer()
        {
            _BallToTest.Reset(2);
            Assert.AreEqual(700, _BallToTest.Xpos);
        }
    }
}
