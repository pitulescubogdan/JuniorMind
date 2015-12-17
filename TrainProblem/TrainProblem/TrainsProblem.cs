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
            Assert.AreEqual(0, CalculateForThreeDistances(10,100));
        }

        public double CalculateForThreeDistances(double constantSpeed,double totalDistance)
        {

            double timeTrain = (totalDistance/4) / constantSpeed;
            double birdDistance = 2 * constantSpeed * timeTrain;

            return birdDistance;
        }

    }
}
