using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
using SharpDX.Windows;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class GameClassTest.
    /// </summary>
    [TestClass]
    public class GameClassTest
    {
        /// <summary>
        /// Defines the test method TestGameStarting.
        /// </summary>
        [TestMethod]
        public void TestGameStarting()
        {
            bool result = true;
            Game GameToTest = new Game();
            try
            {
                GameToTest.Run();
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
    }
}
