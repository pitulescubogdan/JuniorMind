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
            Assert.AreEqual(100, CalculateTotalDistance(participant));
        }
        public double CalculateTotalDistance(Cycle[] participants)
        {
            return 0;
        }
    }
}
