using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
using SharpDX.Windows;
using SharpDX.Direct2D1;
using PingPongGraphicsClassLibrary;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class GraphicsStarterTest.
    /// </summary>
    [TestClass]
    public class GraphicsStarterTest
    {
        /// <summary>
        /// Defines the test method TestGraphicsStarter.
        /// </summary>
        [TestMethod]
        public void TestGraphicsStarter()
        {
            RenderForm rform = new RenderForm();
            GraphicStarter GFToTest = new GraphicStarter(rform);
            Factory factoryToTest = new Factory(FactoryType.SingleThreaded);
            GFToTest.Initialize(rform);
            Assert.AreEqual(factoryToTest.GetType(), GFToTest.BaseFactory.GetType());
        }
        /// <summary>
        /// Defines the test method TestGraphicsStarterDispose.
        /// </summary>
        [TestMethod]
        public void TestGraphicsStarterDispose()
        {
            RenderForm rform = new RenderForm();
            GraphicStarter GFToTest = new GraphicStarter(rform);
            Factory factoryToTest = new Factory(FactoryType.SingleThreaded);
            bool resultOfWorking = true;
            try
            {
                GFToTest.Dispose();
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
        /// Defines the test method TestGraphicsStarterConstruct.
        /// </summary>
        [TestMethod]
        public void TestGraphicsStarterConstruct()
        {
            RenderForm rform = new RenderForm();
          
            bool resultOfWorking = true;
            try
            {
                GraphicStarter GFToTest = new GraphicStarter(rform);
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
        /// Defines the test method TestGraphicsGetterDirectFactory.
        /// </summary>
        [TestMethod]
        public void TestGraphicsGetterDirectFactory()
        {
            RenderForm rform = new RenderForm();
            GraphicStarter GFToTest = new GraphicStarter(rform);
            bool resultOfWorking = true;
            Assert.IsNotNull(GFToTest.DirectFactory);
        }
        /// <summary>
        /// Defines the test method TestGraphicsGetterBaseFactory.
        /// </summary>
        [TestMethod]
        public void TestGraphicsGetterBaseFactory()
        {
            RenderForm rform = new RenderForm();
            GraphicStarter GFToTest = new GraphicStarter(rform);
            bool resultOfWorking = true;
            Assert.IsNotNull(GFToTest.BaseFactory);
        }
     
    }
}
