using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpDX.Direct2D1;
using SharpDX.Windows;
using PingPongGraphicsClassLibrary;
using PingPongGameClassLibrary;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class GraphicsDrawerTest.
    /// </summary>
    [TestClass]
    public class GraphicsDrawerTest
    {
        /// <summary>
        /// Defines the test method TestBeginDrawMethod.
        /// </summary>
        [TestMethod]
        public void TestBeginDrawMethod()
        {
            RenderForm rform = new RenderForm();
            GraphicsDrawer GDToTest = new GraphicsDrawer(rform);
            MainGameObjectsWorker GOWorker = new MainGameObjectsWorker();
            bool resultOfWorking = true;
            try
            {
                GDToTest.BeginDraw();
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
        /// Tests the end draw method.
        /// </summary>
        public void TestEndDrawMethod()
        {
            RenderForm rform = new RenderForm();
            GraphicsDrawer GDToTest = new GraphicsDrawer(rform);
            MainGameObjectsWorker GOWorker = new MainGameObjectsWorker();
            bool resultOfWorking = true;
            try
            {
               
                GDToTest.EndDraw();
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
