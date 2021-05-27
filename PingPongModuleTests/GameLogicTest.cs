using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
using SharpDX.Windows;
using System.Collections.Generic;
using System.Windows.Input;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class ObjectsMassWorkerTest.
    /// </summary>
    [TestClass]
    public class GameLogicTest
    {
        /// <summary>
        /// Defines the test method TestObjectsMassWorker.
        /// </summary>
        [TestMethod]
        public void TestGameLogic()
        {
            RenderForm form = new RenderForm();
            MainGameObjectsWorker worker = new MainGameObjectsWorker();
            List<BonusBox> list = new List<BonusBox>();
            worker.CurrentBall.Xpos = 619;
            worker.CurrentBall.Ypos = 196;
            worker.CurrentBall.SpeedX = 465;
            worker.CurrentBall.SpeedY = -89;
            list.Add(new BigPaddleBonusBox(600, 158));
    
            GameLogic LogicToTest = new GameLogic(form, worker);
            LogicToTest._boxes = list;
            bool result = true;
            try
            {
                LogicToTest.BonusHit();
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
        /// <summary>
        /// Defines the test method TestGameLogicSpeedBallBonusHit.
        /// </summary>
        [TestMethod]
        public void TestGameLogicSpeedBallBonusHit()
        {
            RenderForm form = new RenderForm();
            MainGameObjectsWorker worker = new MainGameObjectsWorker();
            List<BonusBox> list = new List<BonusBox>();
            worker.CurrentBall.Xpos = 619;
            worker.CurrentBall.Ypos = 196;
            worker.CurrentBall.SpeedX = 465;
            worker.CurrentBall.SpeedY = -89;
            list.Add(new SpeedBallBonusBox(600, 158));
            GameLogic LogicToTest = new GameLogic(form, worker);
            LogicToTest._boxes= list;
            
            bool result = true;
            try
            {
                LogicToTest.BonusHit();
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
        /// <summary>
        /// Defines the test method TestGameLogicSmallPaddleBonusHit.
        /// </summary>
        [TestMethod]
        public void TestGameLogicSmallPaddleBonusHit()
        {
            RenderForm form = new RenderForm();
            MainGameObjectsWorker worker = new MainGameObjectsWorker();
            List<BonusBox> list = new List<BonusBox>();
            worker.CurrentBall.Xpos = 619;
            worker.CurrentBall.Ypos = 196;
            worker.CurrentBall.SpeedX = 465;
            worker.CurrentBall.SpeedY = -89;
            list.Add(new SmallPaddleBonusBox(600, 158));
            GameLogic LogicToTest = new GameLogic(form, worker);
            LogicToTest._boxes = list;

            bool result = true;
            try
            {
                LogicToTest.BonusHit();
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
        /// <summary>
        /// Defines the test method TestGameLogicRoundRestart.
        /// </summary>
        [TestMethod]
        public void TestGameLogicRoundRestart()
        {
            RenderForm form = new RenderForm();
            MainGameObjectsWorker worker = new MainGameObjectsWorker();
         
            GameLogic LogicToTest = new GameLogic(form, worker);
            bool result = true;
            try
            {
                LogicToTest.RoundRestart();
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
        /// <summary>
        /// Defines the test method TestGameLogicRoundOver.
        /// </summary>
        [TestMethod]
        public void TestGameLogicRoundOver()
        {
            RenderForm form = new RenderForm();
            form.Width = 600;
            MainGameObjectsWorker worker = new MainGameObjectsWorker();

            GameLogic LogicToTest = new GameLogic(form, worker);
            LogicToTest._FrameObjects.CurrentBall.Xpos = 700;
            bool result = false;
            try
            {
                LogicToTest.RoundOver();
                result = LogicToTest._RoundIsPlaying;
            }
            catch
            {
                result = true;
            }
            finally
            {
                Assert.IsFalse(result);
            }
        }

    }
}
