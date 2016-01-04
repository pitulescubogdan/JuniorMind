using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rent
{
    [TestClass]
    public class Rent
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(251, CalculateMonthlyRate(250,10));
        }
        public decimal CalculateMonthlyRate(decimal MonthlyRate,int PenaltyDays)
        {

            return 0;
        }
    }
}
