using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
using System.Collections.Generic;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class MainGameObjectsWorkerTest.
    /// </summary>
    [TestClass]
    public class MainGameObjectsWorkerTest
    {
        /// <summary>
        /// Defines the test method TestPlayersMaking.
        /// </summary>
        [TestMethod]
        public void TestPlayersMaking()
        {
            MainGameObjectsWorker GOWorkerToTest = new MainGameObjectsWorker();
            FirstPlayer PlayerToCheck = new FirstPlayer(765, 300);
            Assert.AreEqual(GOWorkerToTest.FirstPlayerGet.Xpos, PlayerToCheck.Xpos);

        }
        /// <summary>
        /// Defines the test method TestResetBoxes.
        /// </summary>
        [TestMethod]
        public void TestResetBoxes()
        {
            MainGameObjectsWorker GOWorkerToTest = new MainGameObjectsWorker();
            BonusBox BoxToTest = new BigPaddleBonusBox(100, 100);
            GOWorkerToTest.Add(BoxToTest);
            int lengthfrst = GOWorkerToTest.Length();
            GOWorkerToTest.ResetBoxes();
            
            Assert.AreEqual(lengthfrst-1,GOWorkerToTest.Length());

        }
        /// <summary>
        /// Defines the test method TestBoxesAdd.
        /// </summary>
        [TestMethod]
        public void TestBoxesAdd()
        {
            MainGameObjectsWorker GOWorkerToTest = new MainGameObjectsWorker();
            BonusBox BoxToTest = new BigPaddleBonusBox(100, 100);
            List<BonusBox> listToAdd = new List<BonusBox>();
            listToAdd.Add(BoxToTest);
            bool resultOfWorking = true;
            try
            {
                GOWorkerToTest.AddBoxes(listToAdd);
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
        /// Defines the test method TestBoxesGet.
        /// </summary>
        [TestMethod]
        public void TestBoxesGet()
        {
            MainGameObjectsWorker GOWorkerToTest = new MainGameObjectsWorker();
            BonusBox BoxToTest = new BigPaddleBonusBox(100, 100);
            BonusBox BoxToCheck;
            List<BonusBox> listToAdd = new List<BonusBox>();
            listToAdd.Add(BoxToTest);
            bool resultOfWorking = true;
            GOWorkerToTest.AddBoxes(listToAdd);
            try
            {
                BoxToCheck =  GOWorkerToTest.GetBonusBox(0);
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
