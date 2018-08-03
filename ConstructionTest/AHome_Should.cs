using System;
using Construction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConstructionTest
{
    [TestClass]
    public class AHome_Should
    {
        [TestMethod]
        public void WhenPainted_BeHabitable()
        {
            //arrange
            var doors = 2;
            var windows = 6;
            Home hs = new Home(doors, windows);


            //act
            hs.PaintHome();
            bool result = hs.IsHabitable();


            //assert
            // Assert.AreEqual(true, result);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WhenBuilt_ShouldHaveTwoDoors()
        {
            //arrange
            Home hs = new Home();

            //act



            //assert
            Assert.AreEqual(2, hs.Doors);
        }
    }
}
