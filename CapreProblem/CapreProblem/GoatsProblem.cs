using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapreProblem
{
    [TestClass]
    public class GoatsProblem
    {
             
        [TestMethod]
        public void CalculateForFiveGoatsForFourDays()
        {
            Assert.AreEqual(10, CalculateHay(1,5,2.5,4,5));
        }

        public double CalculateHay(double setDays, int setGoats, double setHayPerKg, double daysTest, int goatsTest)
        {

            double hayConsumed =(double)((daysTest * goatsTest * setHayPerKg)/(setGoats * setDays));

            return hayConsumed;
        }
    }
}
