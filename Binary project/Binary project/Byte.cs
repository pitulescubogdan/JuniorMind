﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binary_project
{
    [TestClass]
    public class Byte
    {
        [TestMethod]
        public void DecimalToByte()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, ToByteConversion(4));
        }
        [TestMethod]
        public void DecimalToByteForTwelve()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0 }, ToByteConversion(12));
        }
        [TestMethod]
        public void DecimalToByteForFortyNine()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1 }, ToByteConversion(49));
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
        [TestMethod]
        public void AndLogic()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1 }, AndOperand(ToByteConversion(5), ToByteConversion(3)));
        }
        [TestMethod]
        public void OrLogic()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, OROperand(ToByteConversion(8), ToByteConversion(2)));
        }
        [TestMethod]
        public void XORLogic()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0 }, XOROperand(ToByteConversion(5), ToByteConversion(3)));
        }
        [TestMethod]
        public void ShiftLeft()
        {
            CollectionAssert.AreEqual(new byte[] {0,0,0}, LeftShift((ToByteConversion(6)), 1));
        }
        [TestMethod]
        public void ShiftRight()
        {
            CollectionAssert.AreEqual(new byte[] {0,0,1}, RightShift((ToByteConversion(5)), 2));
        }
        [TestMethod]
        public void LessThan()
        {
            Assert.AreEqual(true, LessThan(ToByteConversion(4), ToByteConversion(8)));
        }
        [TestMethod]
        public void TestGetAT()
        {
            Assert.AreEqual(0, GetAt(ToByteConversion(2), 4));
        }
        [TestMethod]
        public void AdditionBinary()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 , 1, 1},Addition(ToByteConversion(7),ToByteConversion(3)));
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
            int i = 1;
            while (number != 0)
            {
                Array.Resize(ref bits, i);
                bits[i - 1] = (byte)(number % 2);
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
            for (int j = 0; j < bitsInserted.Length; j++)
            {
                output[j] = bitsInserted[bitsInserted.Length - k];
                k++;
            }
            return output;
        }
        public byte[] AddBits(byte[] bitsExcepted)
        {

            if (bitsExcepted.Length % 2 == 0)
            {
                Array.Resize(ref bitsExcepted, bitsExcepted.Length + 4 - (bitsExcepted.Length % 4));
            }

            return bitsExcepted;
        }
        public byte[] AndOperand(byte[] firstBits, byte[] secondBits)
        {
            byte[] andBits = new byte[Math.Max(firstBits.Length, secondBits.Length)];

            
            andBits = Decision(firstBits, secondBits, "and");

            
            return ReverseBits(andBits);
        }
        public byte[] OROperand(byte[] firstBits, byte[] secondBits)
        {
            byte[] orBits = new byte[Math.Max(firstBits.Length, secondBits.Length)];

            orBits = Decision(firstBits, secondBits, "or");

            return ReverseBits(orBits);
        }
        public byte[] XOROperand(byte[] firstBits, byte[] secondBits)
        {

            byte[] xorBits = new byte[Math.Max(firstBits.Length, secondBits.Length)];


            xorBits = Decision(firstBits, secondBits, "xor");

           
            return ReverseBits(xorBits);
        }
        public byte[] RightShift(byte[] bitsInserted, int numberOfShifting)
        {
            byte[] result = new byte[bitsInserted.Length];

            for (int i = 0; i < bitsInserted.Length; i++)
            {
                result[bitsInserted.Length - 1 - i] = GetAt(bitsInserted, i + numberOfShifting);
                numberOfShifting++;
            }

            return result;
        }
        public byte[] LeftShift(byte[] bitsInserted, int numberOfShifting)
        {
            byte[] result = new byte[bitsInserted.Length];
            for (int i = 0; i <=numberOfShifting ;i--)
            {
                result[i] = GetAt(bitsInserted, bitsInserted.Length - 1 + i );     
            }

            return result;
        }
        public bool LessThan(byte[] numberToCheck, byte[] numberToBeChecked)
        {
            bool result = true;
            for (int i = 0; i < Math.Max(numberToBeChecked.Length, numberToCheck.Length); i++)
            {
                result = (GetAt(numberToCheck, i) < GetAt(numberToBeChecked, i)) ? true : false;
            }

                return result;

        }
        public byte GetAt(byte[] bitsInserted, int indexPosition)
        {
            return (indexPosition > bitsInserted.Length - 1 || indexPosition < 0) ? (byte)0 : bitsInserted[bitsInserted.Length - 1 - indexPosition];
        }
        public byte[] Decision(byte[] firstBits, byte[] secondBits, string decision)
        {
            byte[] result = new byte[Math.Max(firstBits.Length, secondBits.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                switch (decision)
                {
                    case "xor":
                       result[i] = (GetAt(firstBits,i) != GetAt(secondBits,i)) ? (byte)1 : (byte)0;
                       break; 
                    case "and":
                       result[i] = (GetAt(firstBits,i) == 1 &&  GetAt(secondBits,i) == 1) ? (byte)1 : (byte)0;
                        break;
                    case "or":
                       result[i] = (GetAt(firstBits,i) == 0 &&  GetAt(secondBits,i) == 0) ? (byte)0 : (byte)1;
                        break;
                }           
            }
             return result;
            
        }
        public byte[] Addition(byte[] firstBits, byte[] secondBits)
        {
            

                return firstBits;
        }
    }
}


