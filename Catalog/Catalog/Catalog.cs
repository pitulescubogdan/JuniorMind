﻿using System;
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
                pupils[4],
                pupils[0]
            };
            CollectionAssert.AreEqual(result, GetPupilsWithLowestAvgMark(pupils));
        }
        [TestMethod]
        public void LowestMarks()
        {
            Pupil[] pupils = new Pupil[]
          {
                new Pupil("Bogdan", new Classes[] {new Classes("Info",new int[] {8,10,9 }) }),
                new Pupil("Mihai",new Classes[] { new Classes("Mate",new int[] {9,9,10 }) }),
                new Pupil("Andrei", new Classes[] { new Classes("Sport",new int[] { 10, 10, 10 }) }),
                new Pupil("Razvan", new Classes[] {new Classes("Romana", new int[] { 10,10,10}) }),
                new Pupil("Paul", new Classes[] {new Classes("Civica",new int[] { 9,10,8})})
          };
            Assert.AreEqual(9, GetLowestMarks(pupils));
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
                for (int i = 0; i < length; i++)
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
            int highest = 0;
            int k = 0;
            int j = 0;
            for (int i = 0; i < pupils.Length; i++)
            {
                while (j < pupils.Length - 1)
                {
                    int actual = pupils[j].nameOfClass[0].CountTens();
                    highest = (actual > highest) ? actual : highest;
                    j++;
                }
                if (highest == pupils[i].nameOfClass[0].CountTens())
                {
                    AddPupilAndResize(pupils, ref result, ref k, i);
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
                BinarySearch(pupils,pupils[i]);
                if (mark == toCompare) AddPupilAndResize(pupils, ref storedPupils, ref k, i);
            }
            Array.Resize(ref storedPupils, storedPupils.Length - 1);
            return storedPupils;
        }
        public Pupil[] GetPupilsWithLowestAvgMark(Pupil[] pupils)
        {
            double comparer = GetLowestMarks(pupils);
            Pupil[] lowestMarks = new Pupil[1];
            int k = 0;
            for (int i = pupils.Length - 1; i >= 0; i--)
            {
                if (pupils[i].nameOfClass[0].AverageMarks() == comparer)
                {
                    AddPupilAndResize(pupils, ref lowestMarks, ref k, i);
                }
            }
            Array.Resize(ref lowestMarks, lowestMarks.Length - 1);
            return lowestMarks;
        }

        private static void AddPupilAndResize(Pupil[] pupils, ref Pupil[] lowestMarks, ref int k, int i)
        {
            lowestMarks[k++] = pupils[i];
            Array.Resize(ref lowestMarks, lowestMarks.Length + 1);
        }

        public double GetLowestMarks(Pupil[] pupils)
        {
            double result = pupils[0].nameOfClass[0].AverageMarks();

            for (int i = 0; i < pupils.Length; i++)
            {
                double comparison = pupils[i].nameOfClass[0].AverageMarks();
                result = (comparison < result) ? comparison : result;
            }
            return result;
        }
        public int BinarySearch(Pupil[] pupils,Pupil toFind)
        {
            int start = 0;
            int end = pupils.Length - 1;
            while(start <= end)
            {
                int pivot = (start + end) / 2;
                if (pupils[pivot].Equals(toFind)) return pivot;
                if (pupils[pivot].nameOfClass[0].CountTens() < toFind.nameOfClass[0].CountTens()) start = pivot + 1;
                else end = pivot - 1;

            }
            return -1;
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






