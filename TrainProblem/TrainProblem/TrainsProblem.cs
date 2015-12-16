﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrainProblem
{
    [TestClass]
    public class TrainsProblem
    {
        [TestMethod]
        public void CalculateDistance()
        {
            Assert.AreEqual(86, CalculateForThreeDistances(90));
        }

        public int CalculateForThreeDistances(float totalDistance)
        {
            float birdDistance = (totalDistance * 2) / 3;
            float remainingDistance = totalDistance - birdDistance;
            float twoJumpsDistance = (remainingDistance * 2 )/ 3 + birdDistance;
            remainingDistance = totalDistance - twoJumpsDistance;
            float threeJumpsDistance =(remainingDistance * 2) / 3 + twoJumpsDistance;
            int result = (int)threeJumpsDistance;

            return result;
        }

    }
}