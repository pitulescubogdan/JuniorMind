using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapreProblem
{
    [TestClass]
    public class Capre
    {
             
        [TestMethod]
        public void CalculateForFiveGoatsForFourDays()
        {
            Assert.AreEqual(10, CalculateHay(1,5,2.5,4,5));
        }

        public double CalculateHay(double days, int goats, double kgHay, double daysTest, int goatsTest)
        {

            double hayConsumed =(double)((daysTest * goatsTest * kgHay)/(goats * days));

            return hayConsumed;
        }
    }
}
