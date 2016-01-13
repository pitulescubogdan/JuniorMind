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
            Assert.AreEqual(7.15112384201851e-8, CalculateChancesLotto(6,49,6));
        }
        
        public double CalculateChancesLotto(int maxWinningNumbers,int amountOfNumbers,int numberGuessed)
        {
            double combinationBofK,combinationPossible, combinationKofN;


            combinationBofK = CalculateFactorial(maxWinningNumbers) /
                (CalculateFactorial(numberGuessed) * CalculateFactorial(maxWinningNumbers - numberGuessed));
            combinationPossible = CalculateFactorial(amountOfNumbers - maxWinningNumbers) /
                (CalculateFactorial(maxWinningNumbers - numberGuessed) *
                CalculateFactorial((amountOfNumbers - maxWinningNumbers) - (maxWinningNumbers - numberGuessed)));
            combinationKofN = CalculateFactorial(amountOfNumbers)/
                CalculateFactorial(maxWinningNumbers) * CalculateFactorial(amountOfNumbers - maxWinningNumbers);


            return 1 / ((combinationBofK * combinationPossible) / combinationKofN);
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
