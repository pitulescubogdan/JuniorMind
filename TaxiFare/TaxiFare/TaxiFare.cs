using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiFare
{
    [TestClass]
    public class TaxiFare
    {
        [TestMethod]
        public void CalculateForDayTime()
        {
            Assert.AreEqual(75, CalculateTaxiFareDayTime(15));
        }
        public decimal CalculateTaxiFareDayTime(int distance)
        {
            decimal feeForTaxi=0;
            int pricePerKm=0;
            if(distance >= 1 && distance <= 20)
            {
                pricePerKm = 5;
                feeForTaxi = distance * pricePerKm;
            }else if(distance >= 21 && distance <= 60)
            {
                pricePerKm = 8;
                feeForTaxi = distance * pricePerKm;
            }
            else if(distance >= 60)
            {
                pricePerKm = 6;
                feeForTaxi = distance * pricePerKm;
            }
            return feeForTaxi;
        }
    }
}
