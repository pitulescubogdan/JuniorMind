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
            Assert.AreEqual(0, CalculateChancesLotto(6,49));
        }
        public double CalculateChancesLotto(int numbersGuessed,int amountOfNumbers)
        {

            return 0;
        }
    }
}
