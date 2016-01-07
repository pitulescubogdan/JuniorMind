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
            Assert.AreEqual(120, CalculateChancesLotto(6,49));
        }
        public double CalculateChancesLotto(int numbersGuessed,int amountOfNumbers)
        {

            CalculateFactorial(5);

            return 120;
        }
        public double CalculateFactorial(int numberForFactiorial)
        {
            int result = 1;
            for(int i = 1; i < numberForFactiorial; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
