using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rent
{
    [TestClass]
    public class Rent
    {
        [TestMethod]
        public void CalculateForNoPenalty()
        {
            Assert.AreEqual(250, CalculateMonthlyRate(250, 0));
        }
        [TestMethod]
        public void CalculateForFirstPenalty()
        {
            Assert.AreEqual(255, CalculateMonthlyRate(250,5));
        }
        [TestMethod]
        public void CalculateForSecondPenalty()
        {
            Assert.AreEqual(262.5, CalculateMonthlyRate(250, 15));
        }
        [TestMethod]
        public void CalculateForThirdPenalty()
        {
            Assert.AreEqual(275, CalculateMonthlyRate(250, 35));
        }
        [TestMethod]
        public void CalculateForOverPenalty()
        {
            Assert.AreEqual(625, CalculateMonthlyRate(250, 45));
        }
        public double CalculateMonthlyRate(double MonthlyRate,int PenaltyDays)
        {
            double RentWithPenalty =0;
            double firstPenalty = 0.02 * MonthlyRate;
            double secondPenalty =0.05 * MonthlyRate;
            double thirdPenalty = 0.1  * MonthlyRate;
            if (PenaltyDays >= 1 && PenaltyDays <= 10)
            {
                return RentWithPenalty = MonthlyRate + firstPenalty;
            }
            else if (PenaltyDays >= 11 && PenaltyDays <= 30)
            {
                return RentWithPenalty = MonthlyRate + secondPenalty;
            }
            else if (PenaltyDays >= 31 && PenaltyDays <= 40)
            {
                return RentWithPenalty = MonthlyRate + thirdPenalty;
            }else if(PenaltyDays >= 40)
            {
                return RentWithPenalty = MonthlyRate + (1.5 * MonthlyRate);
            }

            return MonthlyRate;

        }
    }
}
