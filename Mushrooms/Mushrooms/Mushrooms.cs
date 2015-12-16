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
            Assert.AreEqual(9, CalculateRedMushrooms(12, 3));
        }
        public int CalculateRedMushrooms(int totalMushrooms, int coefficient)
        {
            int whiteMushroomns = totalMushrooms / (coefficient + 1);
            int redMushrooms = totalMushrooms - whiteMushroomns;

            return redMushrooms;
        }
    }
}
