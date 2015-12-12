using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemeJuniorMind
{
    [TestClass]
    public class ProblemaPasaje
    {

        [TestMethod]
        public void TestMethod1()
        {
            double result = CalculPietre(23, 25, 5);
            Assert.AreEqual(25, result);
        }

        double CalculPietre(int lungime, int latime, int laturaPiatra)
        {
            double resultLungime, resultLatime;
            resultLungime = (double)lungime / laturaPiatra;
            resultLatime = (double)latime / laturaPiatra;

            return (Math.Ceiling(resultLatime)) * Math.Ceiling(resultLungime);
        }
    }
}
