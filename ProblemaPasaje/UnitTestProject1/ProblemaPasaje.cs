using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemeJuniorMind
{
    [TestClass]
    public class ProblemaPasaje
    {

        [TestMethod]
        public void CalculateNumberOfStones()
        {
            double result = CalculStones(23, 25, 5);
            Assert.AreEqual(25, result);
        }

        double CalculStones(int PlazaHeight, int PlazaWidth, int stoneLength)
        {
            double resultHeight, resultWidth;
            resultHeight = (double)PlazaHeight / stoneLength;
            resultWidth = (double)PlazaWidth / stoneLength;

            return (Math.Ceiling(resultHeight)) * Math.Ceiling(resultWidth);
        }
    }
}
