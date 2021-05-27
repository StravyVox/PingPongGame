using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
using SharpDX.Windows;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class MainEngineTest.
    /// </summary>
    [TestClass]
    public class MainEngineTest
    {
        /// <summary>
        /// Defines the test method TestMainEngineStartLogic.
        /// </summary>
        [TestMethod]
        public void TestMainEngineStartLogic()
        {
            RenderForm rform = new RenderForm();
            MainEngine MainToTest = new MainEngine(rform);
            bool resultOfWorking = true;
            try
            {
                MainToTest.Logic();
            }
            catch
            {
                resultOfWorking = false;
            }
            finally
            {
                Assert.IsTrue(resultOfWorking);
            }
        }
        /// <summary>
        /// Defines the test method TestMainEngineStartFrameDraw.
        /// </summary>
        [TestMethod]
        public void TestMainEngineStartFrameDraw()
        {
            RenderForm rform = new RenderForm();
            MainEngine MainToTest = new MainEngine(rform);
            bool resultOfWorking = true;
            try
            {
                MainToTest.FrameDraw();
            }
            catch
            {
                resultOfWorking = false;
            }
            finally
            {
                Assert.IsTrue(resultOfWorking);
            }
        }
        /// <summary>
        /// Defines the test method TestMainEngineDispose.
        /// </summary>
        [TestMethod]
        public void TestMainEngineDispose()
        {
            RenderForm rform = new RenderForm();
            MainEngine MainToTest = new MainEngine(rform);
            bool resultOfWorking = true;
            try
            {
                MainToTest.Dispose();
            }
            catch
            {
                resultOfWorking = false;
            }
            finally
            {
                Assert.IsTrue(resultOfWorking);
            }
        }
        /// <summary>
        /// Defines the test method TestMainEngineRestart.
        /// </summary>
        [TestMethod]
        public void TestMainEngineRestart()
        {
            RenderForm rform = new RenderForm();
            MainEngine MainToTest = new MainEngine(rform);
            bool resultOfWorking = true;
            try
            {
                MainToTest.Restart();
            }
            catch
            {
                resultOfWorking = false;
            }
            finally
            {
                Assert.IsTrue(resultOfWorking);
            }
        }
    }
}
