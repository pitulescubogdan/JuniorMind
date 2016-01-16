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
        public void DecimalToByteForTwelve()
        {
           CollectionAssert.AreEqual(new byte[] {1,1,0,0},(ToByteConversion(12)));            
        }
        [TestMethod]
        public void DecimalToByteForFortyNine()
        {
           CollectionAssert.AreEqual(new byte[] {1,1,0,0,0,1},(ToByteConversion(49)));                       
        }
        [TestMethod]
        public void MyTestMethod()
        {
            Assert.AreEqual(206, NotByte(49));                                   
        }

        public int NotByte(int number)
        {
            byte result =(byte) ~number;
            return result;
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

 

                        
