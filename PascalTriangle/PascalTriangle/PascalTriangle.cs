using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalTriangle
{
    [TestClass]
    public class PascalTriangle
    {
        [TestMethod]
        public void PascalOneRow()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, GetPascal(1));
        }

        [TestMethod]
        public void PascalForRowThree()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, GetPascal(3));

        }
        [TestMethod]
        public void PascalForFourthRow()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 3, 1 }, GetPascal(4));

        }
        [TestMethod]
        public void PascalForSeventhRow()
        {
            CollectionAssert.AreEqual(new int[] { 1, 6, 15, 20, 15, 6, 1 }, GetPascal(7));

        }

        public int[] GetPascal(int row)
        {
            int[] output = new int[row];
            if (row == 1)
            {
                return new int[] { 1 };
            }
            output[0] = 1;
            output[row - 1] = 1;
            int[] beforeRow = GetPascal(row - 1);
            for (int i = 1; i < row - 1; i++)
            {
                output[i] = beforeRow[i - 1] + beforeRow[i];
            }

            return output;
        }

        public int GetNumber(int[] number)
        {
            return number[0];
        }
    }
}
