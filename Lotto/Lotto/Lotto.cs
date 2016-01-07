using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lotto
{
    [TestClass]
    public class Lotto
    {
        [TestMethod]
        public void LottoForSixOfSixtyNine()
        {
            Assert.AreEqual(7.15112384201851e-8, CalculateChancesLotto(6,49));
        }
        [TestMethod]
        public void LottoForFiveOfSixtyNine()
        {
            Assert.AreEqual(5.244157484146912e-7, CalculateChancesLotto(5, 49));

        }
        [TestMethod]
        public void LottoForFourOfSixtyNine()
        {
            Assert.AreEqual(4.719741735732221e-6, CalculateChancesLotto(4, 49));

        }
        [TestMethod]
        public void LottoForFiveOfForty()
        {
            Assert.AreEqual(1.519738361843625e-6, CalculateChancesLotto(5, 40));

        }
        public double CalculateChancesLotto(int numbersGuessed,int amountOfNumbers)
        {
            double combination;

            combination = CalculateFactorial(amountOfNumbers)/
                (CalculateFactorial(numbersGuessed)*CalculateFactorial(amountOfNumbers- numbersGuessed));

            return 1 / combination;
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
