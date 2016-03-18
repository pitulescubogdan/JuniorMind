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
            CollectionAssert.AreEqual(new int[] { 1 }, GetPascal(1));
        }

        [TestMethod]
        public void PascalForRowThreeColumnTwo()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, GetPascal(3));

        }
    public int[] GetPascal(int row)
        {
            int[] output = new int[row];
            if (row == 1 )
            {
                return new int[] { 1 };
            }
            output[0] = 1;
            output[row - 1] = 1;
            for (int i = 1;i< row - 1; i++)
            {
                
                output[i] = GetNumber(GetPascal(i)) + GetNumber(GetPascal(i+1));
            }
           
            return output;
        }
        public int GetSum(int[] row)
        {
          return row[row.Length - 1] + row[row.Length - 2];
        }
        public int GetNumber(int[] number)
        {
            return number[0];
        }
    }
}
