using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class Mushrooms
    {
        [TestMethod]
        public void CalculateMushrooms()
        {
            Assert.AreEqual(1, CalculateRedMushrooms(9, 3));
        }
        public double CalculateRedMushrooms(double totalMushrooms, double coefficient)
        {
            double whiteMushroomns = totalMushrooms / (coefficient + 1);
            double redMushrooms = totalMushrooms - whiteMushroomns;

            return redMushrooms;
        }
    }
}
