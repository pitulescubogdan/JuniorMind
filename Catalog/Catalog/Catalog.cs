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

            CollectionAssert.AreEqual(sorted, SortAvgMark(pupils));
        }
        [TestMethod]
        public void SearchForPupils()
        {
            Pupil[] pupils = new Pupil[]
            {
                new Pupil("Bogdan", new Classes[] {new Classes("Info",new int[] {8,10,9 }) }),
                new Pupil("Mihai",new Classes[] { new Classes("Mate",new int[] {9,9,10 }) }),
                new Pupil("Andrei", new Classes[] { new Classes("Sport",new int[] { 10, 10, 10 }) }),
                new Pupil("Razvan", new Classes[] {new Classes("Romana", new int[] { 10,10,10}) }),
                new Pupil("Paul", new Classes[] {new Classes("Civica",new int[] { 9,10,8})})
            };
            Pupil[] found = new Pupil[]
            {
                pupils[0],
                pupils[4]
            };
            CollectionAssert.AreEqual(found, GetPupilByAvgMark(pupils, 9));
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
            public double AverageMarks()
            {
                double hold = 0;
                int length = marks.Length;
                for (int i = 0; i < length; i++)
                {
                    hold += marks[i];
                }
                return hold / length;
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
        public Pupil[] SortAvgMark(Pupil[] classes)
        {
            for (int i = 0; i < classes.Length - 1; i++)
            {
                int k = i + 1;
                while (k > 0)
                {
                    if (classes[k - 1].nameOfClass[0].AverageMarks() < classes[k].nameOfClass[0].AverageMarks()) SwapPupils(classes, k);

                    k--;
                }
            }
            return classes;
        }
        private static void SwapPupils(Pupil[] pupils, int k)
        {
            var temp = pupils[k - 1];
            pupils[k - 1] = pupils[k];
            pupils[k] = temp;
        }
        public Pupil[] GetPupilByAvgMark(Pupil[] pupils, double mark)
        {
            SortAvgMark(pupils);
            Pupil[] storedPupils = new Pupil[1];
            Pupil[] temporaryPupil = new Pupil[pupils.Length];
            int k = 0;
            int pivot = pupils.Length / 2;
            for (int i = 0; i < pupils.Length; i++)
            {
                double toCompare = pupils[i].nameOfClass[0].AverageMarks();
                if (mark != toCompare)
                {
                    Pupil comparer = pupils[pivot];
                    while (comparer.nameOfClass[0].AverageMarks() != mark)
                    {
                        temporaryPupil = (comparer.nameOfClass[0].AverageMarks() < toCompare)
                            ? ReturnHalf(pupils, 0, pivot)
                            : ReturnHalf(pupils, pivot, pupils.Length - pivot);
                        pivot = pivot / 2;
                        break;
                    }

                }
                if (mark == toCompare)
                {
                    storedPupils[k++] = pupils[i];
                    Array.Resize(ref storedPupils, storedPupils.Length + 1);
                }
            }
            Array.Resize(ref storedPupils, storedPupils.Length - 1);
            return storedPupils;
        }
        public Pupil[] ReturnHalf(Pupil[] array, int start, int length)
        {
            Pupil[] result = new Pupil[array.Length];
            Array.Copy(array, start, result, 0, length);
            return result;
        }
    }
}






