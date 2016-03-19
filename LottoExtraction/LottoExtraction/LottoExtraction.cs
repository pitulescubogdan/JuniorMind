using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoExtraction
{
    [TestClass]
    public class LottoExtraction
    {
        [TestMethod]
        public void TestSort()
        {
            
            Assert.IsTrue(AreSorted(SortNumbers(1, 10, 5)));
        }
        [TestMethod]
        public void AreSortedTest()
        {
            int[] numbers = { 0, 5, 6, 9 };
            Assert.IsTrue(AreSorted(numbers));
        }
        [TestMethod]
        public void SortingForBigIntervals()
        {
            Assert.IsTrue(AreSorted(SortNumbers(1, 49, 6)));
        }

        public int[] SortNumbers(int start, int end, int amount)
        {
            int number = 0;
            int[] numbers = new int[amount];
            int i = 0;

            GenerateNumbersAndStoreThem(start, end, amount, ref number, numbers, ref i);

            return SortNumbers(numbers);
        }
        private static void GenerateNumbersAndStoreThem(int start, int end, int amount, ref int number, int[] numbers, ref int i)
        {
            Random rand = new Random();
            while (amount != 0)
            {
                number = rand.Next(start, end);
                numbers[i++] = number;
                amount--;
            }
        }
        public int[] SortNumbers(int[] inputArray)
        {
            while (!AreSorted(inputArray))
            {
                for (int i = 1; i < inputArray.Length; i++)
                {
                    if (inputArray[i - 1] > inputArray[i])
                    {
                        int hold = inputArray[i - 1];
                        inputArray[i - 1] = inputArray[i];
                        inputArray[i] = hold;
                    }
                }
            }
            return inputArray;
        }
        public bool AreSorted(int[] inputNumbers)
        {
            for(int i = 1; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i - 1] > inputNumbers[i]) return false;
            }
            return true;
        }
    }
}
