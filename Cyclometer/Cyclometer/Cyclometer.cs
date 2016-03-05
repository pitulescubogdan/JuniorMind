using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
{
    [TestClass]
    public class Cyclometer
    {
        public struct Record
        {
            public double rotations;
            public double second;

            public Record(double rotations, double second)
            {
                this.rotations = rotations;
                this.second = second;
            }
        }
        public struct Participant
        {
            public string name;
            public double diameter;
            public Record[] recordings;


            public Participant(string name, double diameter, Record[] recordings)
            {
                this.name = name;
                this.diameter = diameter;
                this.recordings = recordings;
            }
        }

        [TestMethod]
        public void TotalDistanceForOneParticipant()
        {
            var participant = new Participant[] {
                new Participant("Bogdan", 0.28, new Record[] { new Record(10,1), new Record(20,2) })
            };
            Assert.AreEqual(17.592, CalculateTotalDistance(participant), 0.001);
        }
        [TestMethod]
        public void EntireDistanceOfAllParticipants()
        {
            var participants = new Participant[] { new Participant("Bogdan", 0.28, new Record[] {new Record(10,1),new Record(20,1)}),
                new Participant("Mihai",0.28,new Record[] {new Record(9,1),new Record(19,1)})
            };
            Assert.AreEqual(34.306, CalculateTotalDistance(participants), 0.001);
        }
        [TestMethod]
        public void TheMaximumSpeed()
        {
            var participants = new Participant[] { new Participant("Bogdan", 0.28, new Record[] { new Record(10, 1), new Record(20, 3) }),
                new Participant("Mihai", 0.28,new Record[] {new Record(8,1),new Record(11,2) })};
            Assert.AreEqual(participants[0], CalculateMaxSpeed(participants));
        }
        [TestMethod]
        public void AverageSpeed()
        {
            var participants = new Participant("Bogdan", 0.28, new Record[] { new Record(10, 1), new Record(20, 3) });
            Assert.AreEqual(4.2, CalculateAverageSpeed(participants));
        }
        [TestMethod]
        public void BestAverageSpeed()
        {
            var participants = new Participant[] { new Participant("Bogdan", 0.28, new Record[] { new Record(10, 1), new Record(20, 3) }),
                new Participant("Mihai", 0.28,new Record[] {new Record(8,1),new Record(11,2) }) };
            Assert.AreEqual(participants[0], GetMaximumAverageParticipant(participants));
        }
        [TestMethod]
        public void GetMaxRotationsTest()
        {
            var participants = new Participant("Bogdan", 0.28, new Record[] { new Record(10, 1), new Record(20, 3) });
            Assert.AreEqual(20, GetMaximRotations(participants));

        }

        public double CalculateTotalDistance(Participant[] participants)
        {
            double result = 0;
            for (int i = 0; i < participants.Length; i++)
            {
                result += CalculateDistance(participants[i]);
            }
            return result;
        }
        public double CalculateDistance(Participant oneParticipant)
        {
            double result = 0;
            for (int i = 0; i < oneParticipant.recordings.Length; i++)
            {
                result = Math.PI * oneParticipant.diameter * oneParticipant.recordings[i].rotations;
            }
            return result;
        }
        public Participant CalculateMaxSpeed(Participant[] participant)
        {
            Participant maxParticipant = participant[0];
            double firstSpeed = participant[0].diameter * GetMaximRotations(participant[0]);
            for (int i = 0; i < participant.Length; i++)
            {
                double speed = participant[i].diameter * GetMaximRotations(participant[i]);
                maxParticipant = (firstSpeed > speed) ? maxParticipant : participant[i];
            }
            return maxParticipant;
        }
        public double CalculateSpeed(Participant participant)
        {
            return (double)participant.diameter * GetRotations(participant);
        }
        public double GetRotations(Participant participant)
        {
            double result = 0;
            for (int i = 0; i < participant.recordings.Length; i++)
            {
                result += participant.recordings[i].rotations;
            }
            return result;
        }
        public double GetMaximRotations(Participant participant)
        {
            double result = participant.recordings[0].rotations;
            for(int i = 0; i < participant.recordings.Length; i++)
            {
                result = (result > participant.recordings[i].rotations) ? result : participant.recordings[i].rotations;
            }
            return result;
        }
        public double CalculateAverageSpeed(Participant participant)
        {
            double avgSpeed = 0;

            avgSpeed = CalculateSpeed(participant);

            return avgSpeed / participant.recordings.Length;
        }
        public Participant GetMaximumAverageParticipant(Participant[] participant)
        {
            var firstParticipant = participant[0];
            for (int i = 0; i < participant.Length; i++)
            {
                firstParticipant = (CalculateAverageSpeed(firstParticipant) > CalculateAverageSpeed(participant[i]))
                    ? firstParticipant : participant[i];
            }

            return firstParticipant;
        }
    }
}
