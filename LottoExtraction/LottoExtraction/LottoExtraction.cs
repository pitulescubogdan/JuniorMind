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
            CollectionAssert.AreEqual(new int[] { 0 }, SortNumbers(1, 10, 5));
        }
        public int[] SortNumbers(int start, int end, int amount)
        {
            return new int[] { 0 };
        }
    }
}
