using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class GameWindowTest.
    /// </summary>
    [TestClass]
    public class GameWindowTest
    {
        /// <summary>
        /// Defines the test method TestGameWindowSizeWidth.
        /// </summary>
        [TestMethod]
        public void TestGameWindowSizeWidth()
        {
            GameWindow GWToTest = new GameWindow(150,150);
            Assert.AreEqual(150, GWToTest.Window.Width);
        }
        /// <summary>
        /// Defines the test method TestGameWindowSizeHeight.
        /// </summary>
        [TestMethod]
        public void TestGameWindowSizeHeight()
        {
            GameWindow GWToTest = new GameWindow(150, 150);
            Assert.AreEqual(150, GWToTest.Window.Height);
        }
    }
}
