using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Construction;
using NUnit;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace NUnitConstruction.Tests
{
    [TestFixture]
    public class AHome_Should
    {

        [TestCase]
        public void WhenBuilt_HaveAtLeastThreeDoors()
        {
            //arrange
            Home hs = new Home();

            //act


            //assert
            Assert.That(hs.Doors, Is.AtLeast(1));
           
          

        }


        public void  WhenBuilt_IsHabitable()
        {
            //arr
            Home hs = new Home();


            //act
            hs.PaintHome();
            bool result = hs.IsHabitable();


            //assert
            Assert.That(result, Is.True);
            Assert.That(result, Is.EqualTo(true));


            Assert.That(result, new EqualConstraint(true));
            Assert.That(result, new TrueConstraint());

        }
    }
}
