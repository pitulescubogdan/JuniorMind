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
            Assert.AreEqual(75, CalculateTaxiFare(15,16));
        }
        [TestMethod]
        public void CalculateForNightTime()
        {
            Assert.AreEqual(105, CalculateTaxiFare(15,2));
        }
        public decimal CalculateTaxiFare(int distanceToTravel, int hourAtTheMoment)
        {
            decimal feeForTaxi = 0;
            int pricePerKm = 0;
            if (hourAtTheMoment >= 8 && hourAtTheMoment <= 21)
            {
                if (distanceToTravel >= 1 && distanceToTravel <= 20)
                {
                    pricePerKm = 5;
                    feeForTaxi = distanceToTravel * pricePerKm;
                }
                else if (distanceToTravel >= 21 && distanceToTravel <= 60)
                {
                    pricePerKm = 8;
                    feeForTaxi = distanceToTravel * pricePerKm;
                }
                else if (distanceToTravel >= 60)
                {
                    pricePerKm = 6;
                    feeForTaxi = distanceToTravel * pricePerKm;
                }
                
            }
            else
            {
                if (distanceToTravel >= 1 && distanceToTravel <= 20)
                {
                    pricePerKm = 7;
                    feeForTaxi = distanceToTravel * pricePerKm;
                }
                else if (distanceToTravel >= 21 && distanceToTravel <= 60)
                {
                    pricePerKm = 10;
                    feeForTaxi = distanceToTravel * pricePerKm;
                }
                else if (distanceToTravel >= 60)
                {
                    pricePerKm = 8;
                    feeForTaxi = distanceToTravel * pricePerKm;
                }
            }
            return feeForTaxi;
        }
    }
}
