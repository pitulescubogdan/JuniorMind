using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binary_project
{
    [TestClass]
    public class Byte
    {
        [TestMethod]
        public void DecimalToByte()
        {
           CollectionAssert.AreEqual(new byte[] {1,1,1},(ToByteConversion(7)));
        }
        public byte[] ToByteConversion(int number)
        {
            byte[] bits = new byte[3];      
            int i = 0;
                while (number >= 1)
                {
                    bits[i] = (byte)(number % 2);
                    number = number / 2;
                    i++;
                }           
            return bits;
        }
    }
}
