using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpDX.Windows;
using SharpDX.Direct2D1;
using PingPongGraphicsClassLibrary;
using PingPongGameClassLibrary;
namespace PingPongModuleTests
{
    [TestClass]
    public class SpriteSheetTest
    {
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
      
        [TestMethod]
        public void TestGetFilename()
        {
            RenderForm rform = new RenderForm();
            GraphicsDrawer GDToTest = new GraphicsDrawer(rform);
            Ball BallToDo = new Ball();
            SpriteSheet spriterToTest = new SpriteSheet(BallToDo.Sprite, GDToTest);
            Assert.IsNotNull(spriterToTest.Filename);
        }
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
