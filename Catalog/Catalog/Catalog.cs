using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalog
{
    [TestClass]
    public class Catalog
    {
        [TestMethod]
        public void OrderAlphabetical()
        {
            Pupil[] pupils = new Pupil[]
            {
                new Pupil("Bogdan", new Classes[] {new Classes("Info",new int[] {8,10,9 }) }),
                new Pupil("Mihai",new Classes[] { new Classes("Mate",new int[] {9,9,10 }) }),
                new Pupil("Andrei", new Classes[] { new Classes("Sport",new int[] { 10, 10, 10 })})
            };
            Pupil[] sorted = new Pupil[]
            {
                pupils[2],
                pupils[0],
                pupils[1]
            };
            CollectionAssert.AreEqual(sorted, SortAplhabetical(pupils));

        }
        [TestMethod]
        public void OrderByAvgMarks()
        {
            Pupil[] pupils = new Pupil[]
            {
                new Pupil("Bogdan", new Classes[] {new Classes("Info",new int[] {8,10,9 }) }),
                new Pupil("Mihai",new Classes[] { new Classes("Mate",new int[] {9,9,10 }) }),
                new Pupil("Andrei", new Classes[] { new Classes("Sport",new int[] { 10, 10, 10 })})
            };
            Pupil[] sorted = new Pupil[]
            {
                pupils[2],
                pupils[1],
                pupils[0]
            };

            CollectionAssert.AreEqual(sorted, SortByAvgMarks(pupils));

        }

        public struct Pupil
        {
            public string name;
            public Classes[] nameOfClass;
            public Pupil(string name, Classes[] nameOfClass)
            {
                this.name = name;
                this.nameOfClass = nameOfClass;
            }
        }
        public struct Classes
        {
            public string name;
            public int[] marks;
            public Classes(string name, int[] marks)
            {
                this.name = name;
                this.marks = marks;
            }
        }
        public Pupil[] SortAplhabetical(Pupil[] pupils)
        {
            for (int i = 0; i < pupils.Length - 1; i++)
            {
                int k = i + 1;
                while (k > 0)
                {
                    if (pupils[k - 1].name[0] > pupils[k].name[0]) SwapPupils(pupils, k);
                    k--;
                }
            }
            return pupils; ;
        }
        public Pupil[] SortByAvgMarks(Pupil[] pupils)
        {
            return pupils;
        }

        private static void SwapPupils(Pupil[] pupils, int k)
        {
            var temp = pupils[k - 1];
            pupils[k - 1] = pupils[k];
            pupils[k] = temp;
        }
    }
}






