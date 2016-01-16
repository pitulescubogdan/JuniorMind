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
           CollectionAssert.AreEqual(new byte[] {1,0,0},(ToByteConversion(4)));
        }
        [TestMethod]
        public void DecimalToByteForFive()
        {
           CollectionAssert.AreEqual(new byte[] {1,0,1},(ToByteConversion(5)));            
        }
        public byte[] ToByteConversion(int number)
        {
            byte[] bits = new byte[0];          
            int size = 0;
            int i = 0;
                while (number != 0)
                {
                    size++;
                    Array.Resize(ref bits, size);                  
                    bits[i] = (byte)(number % 2);                                       
                    i++;                                    
                    number = number / 2;
                }              
                return revertBytes(bits);
        }
        public byte[] revertBytes(byte[] bitsInserted)
        {
            byte[] output = new byte[bitsInserted.Length];
            int k = 1;
            for (int j = 0; j < bitsInserted.Length; j++)               
                {
                    output[j] = bitsInserted[bitsInserted.Length - k];
                    k++;
                }
            return output;
        }
    }
}

 

                        
