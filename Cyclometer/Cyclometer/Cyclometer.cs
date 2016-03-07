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
        public struct PersonNameSecond
        {
            string name;
            double second;
            public PersonNameSecond(string name, double second)
            {
                this.name = name;
                this.second = second;
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
            Assert.AreEqual(new PersonNameSecond("Bogdan", 3), CalculateMaxSpeed(participants));
        }
        [TestMethod]
        public void AverageSpeed()
        {
            var participants = new Participant("Bogdan", 0.28, new Record[] { new Record(10, 1), new Record(20, 3) });
            Assert.AreEqual(8.796, CalculateAverageSpeed(participants),0.001);
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
            var participant = new Participant("Bogdan", 0.28, new Record[] { new Record(10, 1), new Record(20, 3) });
            Assert.AreEqual(20, GetMaximRotations(participant));
        }
        [TestMethod]
        public void MaximumRotationsBetweenThreeParticipants()
        {
            var participants = new Participant[] {
                new Participant("Bogdan",0.28,new Record[] { new Record(10,1),new Record(20,3)}),
                new Participant("Mihai",0.28,new Record[] {new Record (8,1),new Record(19,2)}),
                new Participant("Alex",0.28,new Record[] {new Record(9,1), new Record(22,2)})
            };
            Assert.AreEqual(new PersonNameSecond("Alex",2), CalculateMaxSpeed(participants));
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
        public PersonNameSecond CalculateMaxSpeed(Participant[] participant)
        {
            PersonNameSecond output = GetNameAndSecond(participant[0],0);
            Participant maxParticipant = participant[0];
            for (int i = 0; i < participant.Length; i++)
            {
                var speed = CalculateSpeed(participant[i]);
                maxParticipant = (CalculateSpeed(maxParticipant) > speed) ? maxParticipant : participant[i];
                output = GetNameAndSecond(maxParticipant, GetPositionOfMaxSpeed(maxParticipant));
            }

            return output;
        }

        private static PersonNameSecond GetNameAndSecond(Participant maxParticipant,int position)
        {
            return new PersonNameSecond(maxParticipant.name, maxParticipant.recordings[position].second);
        }
        public int GetPositionOfMaxSpeed(Participant participant)
        {
            int position = 0;

            for(int i = 0; i < participant.recordings.Length; i++)
            {
                double firstSpeed = participant.diameter * participant.recordings[0].rotations;
                double actualSpeed = participant.diameter * participant.recordings[i].rotations;
                position = (firstSpeed > actualSpeed) ? 0 : i;
            }            
            return position;
        }
        public double CalculateSpeed(Participant participant)
        {
            return participant.diameter * GetMaximRotations(participant);
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
            for (int i = 0; i < participant.recordings.Length; i++)
            {
                result = (result > participant.recordings[i].rotations) ? result : participant.recordings[i].rotations;
            }
            return result;
        }
        public double CalculateAverageSpeed(Participant participant)
        {
            return CalculateDistance(participant) / participant.recordings.Length;
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
