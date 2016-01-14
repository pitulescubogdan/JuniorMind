using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class Lunch
    {
        [TestMethod]
        public void testSmallesCommonDivizor()
        {
            Assert.AreEqual(2, SmallestDivizor(4, 6));
        }
        [TestMethod]
        public void SmallesCommonMultiple()
        {
            Assert.AreEqual(12, smallestCommonMultiple(4, 6));
            
        }
        public int SmallestDivizor(int numberOne, int numberTwo)
        {
            int commonDivizor = 0;
            while (numberOne != numberTwo)
            {
                if (numberOne > numberTwo) numberOne -= numberTwo;
                else numberTwo -= numberOne;
            }
            return commonDivizor = numberOne;           
        }
        public int smallestCommonMultiple(int numberOne, int numberTwo)
        {

            return numberOne * numberTwo / SmallestDivizor(numberOne, numberTwo);
        }
    }
}
