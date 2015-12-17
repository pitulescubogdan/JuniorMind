using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemaSportiv
{
    [TestClass]
    public class SportivProblem
    {
        [TestMethod]
        public void Repetetions()
        {
            int result = calculRepetitions(6);
            Assert.AreEqual(36, result);
        }
        public int calculRepetitions(int rounds)
        {
            int repetitions = rounds * rounds;

            return repetitions;
        }
    }
}
