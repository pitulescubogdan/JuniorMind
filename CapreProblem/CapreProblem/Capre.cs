using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapreProblem
{
    [TestClass]
    public class Capre
    {
        [TestMethod]
        public void CalculateForTenGoatsPerDay()
        {
            Assert.AreEqual(10, CalculFanCapre(1,10));
        }
        [TestMethod]
        public void CalculateForFiveGoatsForFourDays()
        {
            Assert.AreEqual(20, CalculFanCapre(4, 5));
        }

        public double CalculFanCapre(double days,double goats)
        {
            double kgFan = days * goats;

            return kgFan;
        }
    }
}
