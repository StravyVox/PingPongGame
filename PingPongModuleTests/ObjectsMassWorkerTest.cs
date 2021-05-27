using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
using System.Collections.Generic;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class ObjectsMassWorkerTest.
    /// </summary>
    [TestClass]
    public class ObjectsMassWorkerTest
    {
        /// <summary>
        /// Defines the test method TestObjectsMassWorker.
        /// </summary>
        [TestMethod]
        public void TestObjectsMassWorker()
        {

            ObjectsMassWorker TestWorker = new ObjectsMassWorker();
            Ball gmToTest = new Ball();
            TestWorker.Add(gmToTest);
            Assert.AreEqual(gmToTest.Scale, TestWorker[0].Scale);

        }
        /// <summary>
        /// Defines the test method TestObjectsMassWorkerList.
        /// </summary>
        [TestMethod]
        public void TestObjectsMassWorkerList()
        {

            ObjectsMassWorker TestWorker = new ObjectsMassWorker();
            Ball gmToTest = new Ball();
            TestWorker.Add(gmToTest);
            Assert.AreEqual(1, TestWorker.ReturnAFullList().Count);

        }
        /// <summary>
        /// Defines the test method TestObjectsMassWorkerListConstruct.
        /// </summary>
        [TestMethod]
        public void TestObjectsMassWorkerListConstruct()
        {

            Ball gmToTest = new Ball();
            List<GameObject> listToAdd = new List<GameObject>();
            listToAdd.Add(gmToTest);
            ObjectsMassWorker TestWorker = new ObjectsMassWorker(listToAdd);
           
            Assert.AreEqual(1, TestWorker.ReturnAFullList().Count);

        }
    }
}
