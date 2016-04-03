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
        [TestMethod]
        public void MostTens()
        {
            Pupil[] pupils = new Pupil[]
            {
                new Pupil("Bogdan", new Classes[] {new Classes("Info",new int[] {8,10,9 }) }),
                new Pupil("Mihai",new Classes[] { new Classes("Mate",new int[] {9,9,10 }) }),
                new Pupil("Andrei", new Classes[] { new Classes("Sport",new int[] { 10, 10, 10 }) }),
                new Pupil("Razvan", new Classes[] {new Classes("Romana", new int[] { 10,10,10}) }),
                new Pupil("Paul", new Classes[] {new Classes("Civica",new int[] { 9,10,8})})
            };

            Pupil[] result = new Pupil[]
            {
                pupils[2],
                pupils[3]
            };

            CollectionAssert.AreEqual(result, GetThePupilWithMostTens(pupils));
        }
        [TestMethod]
        public void MaxNumberOfTens()
        {
            Pupil[] pupils = new Pupil[]
            {
                new Pupil("Bogdan", new Classes[] {new Classes("Info",new int[] {8,10,9 }) }),
                new Pupil("Mihai",new Classes[] { new Classes("Mate",new int[] {9,9,10 }) }),
                new Pupil("Andrei", new Classes[] { new Classes("Sport",new int[] { 10, 10, 10 }) }),
                new Pupil("Razvan", new Classes[] {new Classes("Romana", new int[] { 10,10,10}) }),
                new Pupil("Paul", new Classes[] {new Classes("Civica",new int[] { 9,10,8})})
            };
            Assert.AreEqual(3, GetHighestNumberOfTens(pupils));
        }
        [TestMethod]
        public void PupilsWithLowesMarks()
        {
            Pupil[] pupils = new Pupil[]
           {
                new Pupil("Bogdan", new Classes[] {new Classes("Info",new int[] {8,10,9 }) }),
                new Pupil("Mihai",new Classes[] { new Classes("Mate",new int[] {9,9,10 }) }),
                new Pupil("Andrei", new Classes[] { new Classes("Sport",new int[] { 10, 10, 10 }) }),
                new Pupil("Razvan", new Classes[] {new Classes("Romana", new int[] { 10,10,10}) }),
                new Pupil("Paul", new Classes[] {new Classes("Civica",new int[] { 9,10,8})})
           };
            Pupil[] result = new Pupil[]
            {
                pupils[0],
                pupils[4]
            };
            CollectionAssert.AreEqual(result, GetPupilsWithLowestAvgMark(pupils));
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
            public int CountTens()
            {
                int length = marks.Length;
                int count = 0;
                for(int i = 0; i < length; i++)
                {
                    if (marks[i].Equals(10)) count++;
                }
                return count;
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
        public Pupil[] GetThePupilWithMostTens(Pupil[] pupils)
        {
            Pupil[] result = new Pupil[1];
            int border = GetHighestNumberOfTens(pupils);
            int k = 0;
            for(int i = 0; i < pupils.Length; i++)
            {
                if(border == pupils[i].nameOfClass[0].CountTens())
                {
                    result[k++] = pupils[i];
                    Array.Resize(ref result, result.Length + 1);
                }
            }
            Array.Resize(ref result, result.Length - 1);
            return result;
        }
        public int GetHighestNumberOfTens(Pupil[] pupils)
        {
            int highest = 0;
            for (int i = 0; i < pupils.Length - 1; i++)
            {
                int actual = pupils[i].nameOfClass[0].CountTens();
                highest = (actual > highest) ? actual : highest;
            }
            return highest;
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
                SearchForPupilIfNotFound(pupils, mark, ref temporaryPupil, ref pivot, toCompare);
                AddPupilFound(pupils, mark, ref storedPupils, ref k, i, toCompare);
            }
            Array.Resize(ref storedPupils, storedPupils.Length - 1);
            return storedPupils;
        }
        public Pupil[] GetPupilsWithLowestAvgMark(Pupil[] pupils)
        {
            return pupils;
        }
        private void SearchForPupilIfNotFound(Pupil[] pupils, double mark, ref Pupil[] temporaryPupil, ref int pivot, double toCompare)
        {
            if (mark != toCompare)
            {
                Pupil comparer = pupils[pivot];
                while (comparer.nameOfClass[0].AverageMarks() != mark)
                {
                    temporaryPupil = SearchForPupil(pupils, ref pivot, toCompare, comparer);
                    break;
                }
            }
        }
        private static void AddPupilFound(Pupil[] pupils, double mark, ref Pupil[] storedPupils, ref int k, int i, double toCompare)
        {
            if (mark == toCompare)
            {
                storedPupils[k++] = pupils[i];
                Array.Resize(ref storedPupils, storedPupils.Length + 1);
            }
        }
        private Pupil[] SearchForPupil(Pupil[] pupils, ref int pivot, double toCompare, Pupil comparer)
        {
            Pupil[] temporaryPupil = (comparer.nameOfClass[0].AverageMarks() < toCompare)
                                        ? ReturnHalf(pupils, 0, pivot)
                                        : ReturnHalf(pupils, pivot, pupils.Length - pivot);
            pivot = pivot / 2;
            return temporaryPupil;
        }
        public Pupil[] ReturnHalf(Pupil[] array, int start, int length)
        {
            Pupil[] result = new Pupil[array.Length];
            Array.Copy(array, start, result, 0, length);
            return result;
        }
    }
}






