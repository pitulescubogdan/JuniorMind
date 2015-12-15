using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiuperciProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateForTwentyMushrooms()
        {
            Assert.AreEqual(15, CalculCiuperci(20,5));
        }
        public double CalculCiuperci(double totalMushrooms,double whiteMushrooms)
        {
            double coeficient = totalMushrooms / whiteMushrooms - 1;
            double redMushrooms = coeficient * whiteMushrooms;

            return redMushrooms;
        }
    }
}
