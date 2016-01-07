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
            Assert.AreEqual(0,00000007, CalculateChancesLotto(6,49));
        }
        public double CalculateChancesLotto(int numbersGuessed,int amountOfNumbers)
        {
            double combination;

            combination = CalculateFactorial(amountOfNumbers)/
                (CalculateFactorial(numbersGuessed)*CalculateFactorial(amountOfNumbers- numbersGuessed));

            return 1/combination;
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
