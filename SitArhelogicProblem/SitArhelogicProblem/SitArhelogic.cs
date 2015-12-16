using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SitArhelogicProblem
{
    [TestClass]
    public class SitArhelogic
    {
        [TestMethod]
        public void CalculateTheArea()
        {
            Assert.AreEqual(14.5, CalculateArea(2,3,3,4,5,2));
        }

        public float CalculateArea(float xOfA,float yOfA,float xOfB,float yOfB,float xOfC,float yOfC)
        {
            float delta = (xOfA * yOfB) + (xOfB * yOfC) + (xOfC * yOfA);

            return delta / 2;
        }
    }
}
