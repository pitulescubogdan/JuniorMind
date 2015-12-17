using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SitArhelogicProblem
{
    [TestClass]
    public class ArhelogicSit
    {
        [TestMethod]
        public void CalculateTheArea()
        {
            Assert.AreEqual(14.5, CalculateArea(2,3,3,4,5,2));
        }

        public float CalculateArea(float firstCoordOfColOne,float secondCoordOfColOne,float firstCoordOfColTwo,float secondCoordOFColTwo,float firstCoordOfColThree,float secondCoordOfColThree)
        {
            float delta = (firstCoordOfColOne * secondCoordOFColTwo) + (firstCoordOfColTwo * secondCoordOfColThree) + (firstCoordOfColThree * secondCoordOfColOne);

            return delta / 2;
        }
    }
}
