using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrainProblem
{
    [TestClass]
    public class TrainsProblem
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(60, CalculateDistance(90));
        }

        public double CalculateDistance(double totalDistance)
        {    
            double birdDistance = (totalDistance * 2) / 3;
            return birdDistance;
        }

    }
}
