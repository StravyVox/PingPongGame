using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpDX.Windows;
using SharpDX.Direct2D1;
using PingPongGraphicsClassLibrary;
using PingPongGameClassLibrary;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class SpriteSheetTest.
    /// </summary>
    [TestClass]
    public class SpriteSheetTest
    {
        /// <summary>
        /// Defines the test method TestReturnBitmap.
        /// </summary>
        [TestMethod]
        public void TestReturnBitmap()
        {
            RenderForm rform = new RenderForm();
            GraphicsDrawer GDToTest = new GraphicsDrawer(rform);
            Ball BallToDo = new Ball();
            SpriteSheet spriterToTest = new SpriteSheet(BallToDo.Sprite, GDToTest);
            bool resultOfWorking = true;
            try
            {
                spriterToTest.ToReturnABitmap();
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
        /// Defines the test method TestGetFilename.
        /// </summary>
        [TestMethod]
        public void TestGetFilename()
        {
            RenderForm rform = new RenderForm();
            GraphicsDrawer GDToTest = new GraphicsDrawer(rform);
            Ball BallToDo = new Ball();
            SpriteSheet spriterToTest = new SpriteSheet(BallToDo.Sprite, GDToTest);
            Assert.IsNotNull(spriterToTest.Filename);
        }
        /// <summary>
        /// Defines the test method TestDispose.
        /// </summary>
        [TestMethod]
        public void TestDispose()
        {
            RenderForm rform = new RenderForm();
            GraphicsDrawer GDToTest = new GraphicsDrawer(rform);
            Ball BallToDo = new Ball();
            SpriteSheet spriterToTest = new SpriteSheet(BallToDo.Sprite, GDToTest);
            bool resultOfWorking = true;
            try
            {
                spriterToTest.Dispose();
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
