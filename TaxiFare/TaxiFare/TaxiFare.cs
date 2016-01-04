﻿using System;
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
        public decimal CalculateTaxiFare(int distance, int hourAtTheMoment)
        {
            decimal feeForTaxi = 0;
            int pricePerKm = 0;
            if (hourAtTheMoment >= 8 && hourAtTheMoment <= 21)
            {
                if (distance >= 1 && distance <= 20)
                {
                    pricePerKm = 5;
                    feeForTaxi = distance * pricePerKm;
                }
                else if (distance >= 21 && distance <= 60)
                {
                    pricePerKm = 8;
                    feeForTaxi = distance * pricePerKm;
                }
                else if (distance >= 60)
                {
                    pricePerKm = 6;
                    feeForTaxi = distance * pricePerKm;
                }
                
            }
            else
            {
                if (distance >= 1 && distance <= 20)
                {
                    pricePerKm = 7;
                    feeForTaxi = distance * pricePerKm;
                }
                else if (distance >= 21 && distance <= 60)
                {
                    pricePerKm = 10;
                    feeForTaxi = distance * pricePerKm;
                }
                else if (distance >= 60)
                {
                    pricePerKm = 8;
                    feeForTaxi = distance * pricePerKm;
                }
            }
            return feeForTaxi;
        }
    }
}
