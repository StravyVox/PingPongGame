using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class PaddleTest.
    /// </summary>
    [TestClass]
    public class PaddleTest
    {

        /// <summary>
        /// The paddle to test
        /// </summary>
        FirstPlayer _PaddleToTest = new FirstPlayer(150, 150);

        /// <summary>
        /// Defines the test method TestMovement.
        /// </summary>
        [TestMethod]
        public void TestMovement()
        {
            int SpeedY = 100;
            _PaddleToTest.MoveToPosition(SpeedY, 800);
            Assert.AreEqual(250, _PaddleToTest.Ypos);
        }
    }
}
