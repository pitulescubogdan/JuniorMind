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
            public double diameter;
            public double rotations;
            public double second;

            public Cycle(string name,double diameter, double rotations, double second)
            {
                this.name = name;
                this.rotations = rotations;
                this.diameter = diameter;
                this.second = second;
            }
        }
        [TestMethod]
        public void TotalDistanceForOneParticipant()
        {
            var participant = new Cycle[] { new Cycle("Bogdan", 3, 0.28,1) };
            Assert.AreEqual(2.6376, CalculateTotalDistance(participant),0.001);
        }
        [TestMethod]
        public void CalculateEntireDistanceOfAllParticipants()
        {
            var participants = new Cycle[] { new Cycle("Bogdan", 3, 0.28,1), new Cycle("Mihai",2,0.28,1) };
            Assert.AreEqual(4.396, CalculateTotalDistance(participants),0.001);
        }
        [TestMethod]
        public void CalculateTheMaximumSpeed()
        {
            var participants = new Cycle[] { new Cycle("Bogdan", 3, 0.28, 1), new Cycle("Mihai", 2, 0.28, 1) };
            Assert.AreEqual(0.84, CalculateMaxSpeed(participants), 0.001);

        }
        public double CalculateTotalDistance(Cycle[] participants)
        {
            double result = 0;
            for (int i = 0; i < participants.Length; i++)
            {
                result += 3.14 * participants[i].diameter * participants[i].rotations;
            }
            return result;
        }
        public double CalculateMaxSpeed(Cycle[] participant)
        {
            double result = 0;
            for(int i = 0; i < participant.Length - 1; i++)
            {
                double speed = participant[i].diameter * participant[i].rotations;
                result = Math.Max(result, speed);
            }
            return result;
        }
    }
}
