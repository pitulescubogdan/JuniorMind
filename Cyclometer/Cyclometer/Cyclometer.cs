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
            public double diameter;

            public Cycle(string name,int rotationPerSecond,double diameter)
            {
                this.name = name;
                this.rotationPerSecond = rotationPerSecond;
                this.diameter = diameter;
            }
        }
        [TestMethod]
        public void TotalDistanceForOneParticipant()
        {
            var participant = new Cycle[] { new Cycle("Bogdan", 250, 0.28) };
            Assert.AreEqual(439.6, CalculateTotalDistance(participant));
        }
        [TestMethod]
        public void CalculateEntireDistanceOfAllParticipants()
        {
            var participants = new Cycle[] { new Cycle("Bogdan", 250, 0.28), new Cycle("Mihai",300,0.28) };
            Assert.AreEqual(967.12, CalculateTotalDistance(participants),1);
        }
        [TestMethod]
     
        public double CalculateTotalDistance(Cycle[] participants)
        {
            double result = 0;
            for (int i = 0; i < participants.Length; i++)
            {
                result += (2 * 3.14 * participants[i].diameter) * participants[i].rotationPerSecond;
            }
            return result;
        }
    }
}
