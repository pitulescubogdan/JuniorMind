using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankRate
{
    [TestClass]
    public class BankRate
    {
        [TestMethod]
        public void BankRateForTheFiftyOneMonth()
        {
            Assert.AreEqual(197m, CalculateRate(40000, 7.57, 240));
        }
        [TestMethod]
        public void BankRateForTwoMonth()
        {
            Assert.AreEqual(56, CalculateRate(100, 10,2));
        }
        public decimal CalculateRate(decimal totalSum, double interestPerYear,decimal monthss)
        {
            decimal sumPerMonth = totalSum / monthss;
            decimal interestForFirstMonth = (decimal) (interestPerYear / 100) * totalSum;
            decimal firstMonth =  sumPerMonth + interestForFirstMonth;
            decimal interestForSecondMonth =(decimal) interestPerYear / 100 * firstMonth;
            decimal secondMonth = sumPerMonth + interestForSecondMonth;
            decimal interestForAnyMonth = (decimal)(interestPerYear / 100) * secondMonth;
            decimal anyMonth = sumPerMonth + interestForAnyMonth;
            
            return anyMonth;
        }
    }
}
