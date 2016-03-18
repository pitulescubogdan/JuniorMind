using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalTriangle
{
    [TestClass]
    public class PascalTriangle
    {
        [TestMethod]
        public void Pascal()
        {
            int row = 1;
            CollectionAssert.AreEqual(new int[] { 1 }, GetPascal(1,ref row));
        }

        [TestMethod]
        public void PascalForRowThreeColumnTwo()
        {
            int row = 3;
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, GetPascal(3,ref row));

        }
    public int[] GetPascal(int row, ref int actualRow)
        {
            int[] output = new int[row];
            if (row == 1 )
            {
                return new int[] { 1 };
            }
             return GetSum(output) + GetPascal(row);
        }
        public int GetSum(int[] row)
        {
          return row[row.Length - 1] + row[row.Length - 2];
        }
    }
}
