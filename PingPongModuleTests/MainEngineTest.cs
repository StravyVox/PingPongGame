using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
using SharpDX.Windows;
namespace PingPongModuleTests
{
    [TestClass]
    public class MainEngineTest
    {
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
