using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGameClassLibrary;
using SharpDX.Windows;
namespace PingPongModuleTests
{
    /// <summary>
    /// Defines test class BonusMakerTest.
    /// </summary>
    [TestClass]
    public class BonusMakerTest
    {
        /// <summary>
        /// Defines the test method TestBoxMaking.
        /// </summary>
        [TestMethod]
        public void TestBoxMaking()
        {
            RenderForm subForm = new RenderForm();
            BonusMaker bonusBoxMaker = new BonusMaker(subForm);
            BonusBox boxToTest = bonusBoxMaker.ToMakeABonus();
            bool result = false;
            if (boxToTest != null)
            {
                result = true;
            }
            Assert.AreEqual(true, result);
        }
        /// <summary>
        /// Defines the test method TestPosition.
        /// </summary>
        [TestMethod]
        public void TestPosition()
        {
            RenderForm subForm = new RenderForm();
            subForm.Width = 800;
            subForm.Height = 600;
            BonusMaker bonusBoxMaker = new BonusMaker(subForm);
            BonusBox boxToTest = bonusBoxMaker.ToMakeABonus();
            bool result = false;
            if (boxToTest.Xpos >=0 && boxToTest.Xpos <=subForm.Width)
            {
                if(boxToTest.Ypos >=0 && boxToTest.Ypos <=subForm.Height)
                result = true;
            }
            Assert.AreEqual(true, result);
        }
    }
}
