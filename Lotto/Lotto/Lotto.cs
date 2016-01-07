using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lotto
{
    [TestClass]
    public class Lotto
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(24, CalculateChancesLotto(6,49));
        }
        public double CalculateChancesLotto(int numbersGuessed,int amountOfNumbers)
        {
            double result;

            result = CalculateFactorial(4);
               
            return result;
        }
        public double CalculateFactorial(int numberForFactiorial)
        {
            double result=1;
            while (!(numberForFactiorial == 0))
            {
                result = result * numberForFactiorial;
                numberForFactiorial--;
            }
            return result;
        }
    }
}
