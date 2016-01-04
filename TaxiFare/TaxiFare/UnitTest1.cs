using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiFare
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(20, CalculateTaxiFare(15, 5));
        }
        public decimal CalculateTaxiFare(int distance, int pricePerKm)
        {

            return 0;
        }
    }
