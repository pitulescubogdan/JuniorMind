using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
{
    [TestClass]
    public class Cyclometer
    {
        public struct Cycle
        {
            public string name;
            public int rotationPerSecond;
            public int diameter;

            public Cycle(string name,int rotationPerSecond,int diameter)
            {
                this.name = name;
                this.rotationPerSecond = rotationPerSecond;
                this.diameter = diameter;
            }
        }
        [TestMethod]
        public void TotalDistance()
        {
            var participant = new Cycle[] { new Cycle("Bogdan", 250, 28) };
            Assert.AreEqual(439.6, CalculateTotalDistance(participant));
        }
        public double CalculateTotalDistance(Cycle[] participants)
        {
            double result = 0;
            for (int i = 0; i < participants.Length; i++)
            {
                result += (2 * 3.14 * 0.28) * participants[i].rotationPerSecond;
            }
            return result;
        }
    }
}
