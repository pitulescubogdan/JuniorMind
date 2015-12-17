using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrainProblem
{
    [TestClass]
    public class TrainsProblem
    {
        [TestMethod]
        public void CalculateDistance()
        {
            Assert.AreEqual(50, CalculateForThreeDistances(10,100));
        }

        public double CalculateForThreeDistances(double constantSpeed,double totalDistance)
        {

            double birdDistance = totalDistance / 2;

            return birdDistance;
        }

    }
}
