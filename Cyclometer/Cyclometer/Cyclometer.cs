using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
{
    [TestClass]
    public class Cyclometer
    {
        public struct Participant
        {
            public string name;
            public double diameter;
            public double rotations;
            public double second;

            public Participant(string name,double diameter, double rotations, double second)
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
            var participant = new Participant[] { new Participant("Bogdan", 3, 0.28,1) };
            Assert.AreEqual(2.6376, CalculateTotalDistance(participant),0.001);
        }
        [TestMethod]
        public void CalculateEntireDistanceOfAllParticipants()
        {
            var participants = new Participant[] { new Participant("Bogdan", 3, 0.28,1), new Participant("Mihai",2,0.28,1) };
            Assert.AreEqual(4.396, CalculateTotalDistance(participants),0.001);
        }
        [TestMethod]
        public void CalculateTheMaximumSpeed()
        {
            var participants = new Participant[] { new Participant("Bogdan", 3, 0.28, 1), new Participant("Mihai", 2, 0.28, 1) };
            var maxSpeed = new Participant("Bogdan", 3, 0.28, 1);
            Assert.AreEqual(maxSpeed, CalculateMaxSpeed(participants));
        }
        [TestMethod]
        public void CalculateMaxSpeedForMoreParticipants()
        {
            var participants = new Participant[] { new Participant("Bogdan", 3, 0.28, 1), new Participant("Mihai", 2, 0.28, 1),new Participant("Dragos",5,0.28,1) };
            var maxSpeed = new Participant("Dragos", 5, 0.28, 1);
            Assert.AreEqual(maxSpeed, CalculateMaxSpeed(participants));
        }
        
        public double CalculateTotalDistance(Participant[] participants)
        {
            double result = 0;
            for (int i = 0; i < participants.Length; i++)
            {
                result += 3.14 * participants[i].diameter * participants[i].rotations;
            }
            return result;
        }
        public Participant CalculateMaxSpeed(Participant[] participant)
        {
            Participant output = participant[0];
            double firstSpeed = participant[0].diameter * participant[0].rotations;

            double result = 0;
            for(int i = 0; i < participant.Length; i++)
            {
                double speed = participant[i].diameter * participant[i].rotations;
                result = Math.Max(result, speed);
                output = (firstSpeed > speed) ? output : participant[i];
            }
            return output;
        }
        
    }
}
