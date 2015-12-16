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
            Assert.AreEqual(2, CalculateFaY(1, 3,2,6,2));
        }

        public double CalculateFaY(double days, int goats, double kgFay, int goatsTest, double daysTest)
        {


            double kgFayConsumed = (days * goatsTest * kgFay) / daysTest * goats; 

            return kgFay;
        }
    }
}
