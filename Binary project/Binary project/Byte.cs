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
           CollectionAssert.AreEqual(new byte[] {1,0,0},ToByteConversion(4));
        }     
        [TestMethod]
        public void DecimalToByteForTwelve()
        {
           CollectionAssert.AreEqual(new byte[] {1,1,0,0},ToByteConversion(12));            
        }
        [TestMethod]
        public void DecimalToByteForFortyNine()
        {
           CollectionAssert.AreEqual(new byte[] {1,1,0,0,0,1},ToByteConversion(49));                       
        }
        [TestMethod]
        public void ConvertFromByteToDecimal()
        {
            Assert.AreEqual(12, ToDecimalConvert(ToByteConversion(12)));
        }
        [TestMethod]
        public void NotByteForNumber()
        {           
            Assert.AreEqual(206,
      ToDecimalConvert(ReverseBits(NotByte(AddBits(ReverseBits(ToByteConversion(49)))))));           
        }
        public byte[] NotByte(byte[] bitsExpected)
        {
            for (int i = 0; i < bitsExpected.Length; i++)
            {
                if (bitsExpected[i] == 0) bitsExpected[i] += 1;
                else if (bitsExpected[i] == 1) bitsExpected[i] -= 1;
            }
            return bitsExpected;
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
                return ReverseBits(bits);               
        }
        public double ToDecimalConvert(byte[] numberInBytes)
        {
            double result = 0;
            for (int j = 0; j < numberInBytes.Length; j++)
            {
                double y = j;
                result += ReverseBits(numberInBytes)[j] * Math.Pow(2, y);
            }          
         
            return result;
        }
        public byte[] ReverseBits(byte[] bitsInserted)
        {
            byte[] output = new byte[bitsInserted.Length];
            int k = 1;
            for (int j =0; j <bitsInserted.Length; j++)
            {
                output[j] = bitsInserted[bitsInserted.Length - k];
                k++;
            }
            return output;  
        }
        public byte[] AddBits(byte[] bitsExcepted){

            if(bitsExcepted.Length % 2 == 0)
            {
                Array.Resize(ref bitsExcepted, bitsExcepted.Length + 4 - (bitsExcepted.Length % 4));
            }

            return bitsExcepted;
        }
    }
}

 

                        
