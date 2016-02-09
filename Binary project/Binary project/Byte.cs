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
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, ToByteConversion(4));
        }
        [TestMethod]
        public void DecimalToByteForTwenty()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0,1,0, 0 }, ToByteConversion(20));
            
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
           CollectionAssert.AreEqual(ToByteConversion(11 << 2), LeftShift((ToByteConversion(11)), 2));
        }
        [TestMethod]
        public void ShiftLeftFor10()
        {
           CollectionAssert.AreEqual(ToByteConversion(10 << 2), LeftShift((ToByteConversion(10)), 2));           
        }
        [TestMethod]
        public void ShiftLeftFor25()
        {
           CollectionAssert.AreEqual(ToByteConversion(25<<3), LeftShift((ToByteConversion(25)), 3));           
            
        }
        [TestMethod]
        public void ShiftRight()
        {
            CollectionAssert.AreEqual(ToByteConversion(5 >> 2), RightShift((ToByteConversion(5)), 2));
        }
        [TestMethod]
        public void ShiftRightFor12()
        {
            CollectionAssert.AreEqual(ToByteConversion(12>>2), RightShift((ToByteConversion(12)), 2));
            
        }
        [TestMethod]
        public void LessThan()
        {
            Assert.AreEqual(true, LessThan(ToByteConversion(4), ToByteConversion(8)));
        }
        [TestMethod]
        public void LessThanBetweenAnyTwoNumbers()
        {
            Assert.AreEqual(true, LessThan(ToByteConversion(3), ToByteConversion(5)));
            
        }
        [TestMethod]
        public void TestGetAT()
        {
            Assert.AreEqual(0, GetAt(ToByteConversion(2), 4));
        }
        [TestMethod]
        public void AdditionBinary()
        {
            CollectionAssert.AreEqual(ToByteConversion(6+6),Addition(ToByteConversion(6),ToByteConversion(6),2));
        }
        [TestMethod]
        public void AdditionWithGreatNumbers()
        {
            CollectionAssert.AreEqual(ToByteConversion(20+5),Addition(ToByteConversion(20),ToByteConversion(5),2));
            
        }
        [TestMethod]
        public void SubstractionBinary()
        {
            CollectionAssert.AreEqual(ToByteConversion(14-4), Substraction(ToByteConversion(14), ToByteConversion(4),2)); 
        }
        [TestMethod]
        public void Multiplication()
        {
            CollectionAssert.AreEqual(ToByteConversionAnyBase((2*3),2), Multiplication(ToByteConversionAnyBase(3,2),ToByteConversionAnyBase(2,2),2));            
        }
        [TestMethod]
        public void MultiplicationWithGreaterNumbers()
        {
            CollectionAssert.AreEqual(ToByteConversionAnyBase((3*4),2), Multiplication(ToByteConversionAnyBase(3,2),ToByteConversionAnyBase(4,2),2));                       
        }
        [TestMethod]
        public void MultiplicationThreeTimesFive()
        {
            CollectionAssert.AreEqual(ToByteConversion(5*3), Multiplication(ToByteConversion(5),ToByteConversion(3),2));                       
            
        }
        [TestMethod]
        public void MultiplicationWithOne()
        {
            CollectionAssert.AreEqual(ToByteConversion(6*1), Multiplication(ToByteConversion(6),ToByteConversion(1),2));            
            
        }
        [TestMethod]
        public void DivisionBinary()
        {
            CollectionAssert.AreEqual(ToByteConversion(12/4), Division(ToByteConversion(12),ToByteConversion(4),2));                       
            
        }
        [TestMethod]
        public void DivisionBetween15and3()
        {
            CollectionAssert.AreEqual(ToByteConversion(15/3), Division(ToByteConversion(15),ToByteConversion(3),2));                       
            
        }
        [TestMethod]
        public void DivisionWithOne()
        {
            CollectionAssert.AreEqual(ToByteConversion(15/1), Division(ToByteConversion(15),ToByteConversion(1),2));                       
            
        }
        [TestMethod]
        public void DivisionByTwo()
        {
            CollectionAssert.AreEqual(ToByteConversion(8/2) ,Division(ToByteConversion(8), ToByteConversion(2),2));                       
            
        }
        [TestMethod]
        public void GreaterThan()
        {
            Assert.AreEqual(true, GreaterThan(ToByteConversion(10), ToByteConversion(5)));            
        }
        [TestMethod]
        public void EqualBetweenTwoNumbers()
        {
            Assert.AreEqual(true, Equal(ToByteConversion(10), ToByteConversion(10)));                   
        }
        [TestMethod]
        public void NotEqualBetweenTwoNumbers()
        {
            Assert.AreEqual(true, NotEqual(ToByteConversion(8), ToByteConversion(5)));                   
            
        }
        [TestMethod]
        public void TestNumberOfZeroes()
        {
            Assert.AreEqual(2, GetNoOfZeroes(ToByteConversion(12)));
        }
        [TestMethod]
        public void ToDecimalConvertInAnyBase()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, ToByteConversion(4));
        }
        [TestMethod]
        public void ToBinaryOfBaseTwo()
        {
            CollectionAssert.AreEqual(ToByteConversion(4), ToByteConversionAnyBase(4,2));           
        }
        [TestMethod]
        public void ToBinaryOfThirdBase()
        {
            CollectionAssert.AreEqual(new byte[] {1,1,2,1}, ToByteConversionAnyBase(43, 3));           
            
        }
        [TestMethod]
        public void ToBinaryForAnyBase()
        {
            CollectionAssert.AreEqual(new byte[] {1,15,12}, ToByteConversionAnyBase(712, 20));           
            
        }
        [TestMethod]
        public void AdditionWithAnyBase()
        {
            CollectionAssert.AreEqual(ToByteConversionAnyBase((82+50),3),Addition(ToByteConversionAnyBase(82,3),ToByteConversionAnyBase(50,3),3));
            
        }
        [TestMethod]
        public void SubstractionWithAnyBase()
        {
            CollectionAssert.AreEqual(ToByteConversionAnyBase((152 - 29), 3), Substraction(ToByteConversionAnyBase(152, 3), ToByteConversionAnyBase(29, 3), 3));
            
        }
        [TestMethod]
        public void SubStractionWithEleventhBase()
        {
            CollectionAssert.AreEqual(ToByteConversionAnyBase((476 - 250), 11), Substraction(ToByteConversionAnyBase(476, 11), ToByteConversionAnyBase(250, 11), 11));
            
        }
        [TestMethod]
        public void MultiplicationWithFifthBase()
        {
            CollectionAssert.AreEqual(ToByteConversionAnyBase((82*50),5),Multiplication(ToByteConversionAnyBase(82,5),ToByteConversionAnyBase(50,5),5));
            
        }
        [TestMethod]
        public void MultiplicationWithGreatBase()
        {
            CollectionAssert.AreEqual(ToByteConversionAnyBase((275*45),20),Multiplication(ToByteConversionAnyBase(275,20),ToByteConversionAnyBase(45,20),20));
            
        }
        [TestMethod]
        public void DivisionWithEightBase()
        {
            CollectionAssert.AreEqual(ToByteConversionAnyBase((1024/64),4),Division(ToByteConversionAnyBase(1204,4),ToByteConversionAnyBase(64,4),4));
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
            return ExecuteLogicOperation(firstBits, secondBits, "and");                       
        }
        public byte[] OROperand(byte[] firstBits, byte[] secondBits)
        {           
            return ExecuteLogicOperation(firstBits, secondBits, "or");

        }
        public byte[] XOROperand(byte[] firstBits, byte[] secondBits)
        {      
            return ExecuteLogicOperation(firstBits, secondBits, "xor");          
        }
        public byte[] RightShift(byte[] bitsInserted, int numberOfShifting)
        {
            Array.Resize(ref bitsInserted, bitsInserted.Length - numberOfShifting);
            return bitsInserted;
        }
        public byte[] LeftShift(byte[] bitsInserted, int numberOfShifting)
        {
            Array.Resize(ref bitsInserted, bitsInserted.Length + numberOfShifting);
            return bitsInserted;
        }
        public bool LessThan(byte[] numberToCheck, byte[] numberToBeCheckedWith)
        {
            for (int i = Math.Max(numberToBeCheckedWith.Length, numberToCheck.Length);i>=0; i--)
            {
                if (GetAt(numberToCheck, i) != GetAt(numberToBeCheckedWith, i))
                {
                    return (GetAt(numberToCheck, i) < GetAt(numberToBeCheckedWith, i));
                }
            }
            return true;
        }
        public byte GetAt(byte[] bitsInserted, int indexPosition)
        {
            return (indexPosition > bitsInserted.Length - 1 || indexPosition < 0) ? (byte)0 : bitsInserted[bitsInserted.Length - 1 - indexPosition];
        }
        public byte[] ExecuteLogicOperation(byte[] firstBits, byte[] secondBits, string decision)
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
             return ReverseBits(result);
            
        }
        public byte[] Addition(byte[] firstBits, byte[] secondBits,int baseBits)
        {
            byte[] result = new byte[Math.Max(firstBits.Length, secondBits.Length)];
            int remainder = 0;
            for (int i = 0; i < result.Length; i++)
            {
                int hold = GetAt(firstBits, i) + GetAt(secondBits, i) + remainder;
                result[result.Length - 1 - i] = (byte)(hold % baseBits);
                remainder = hold / baseBits;               
            }
            
                if (remainder != 0)
                {
                    Array.Reverse(result);
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = (byte)1;
                    Array.Reverse(result);
                }               
            return result;
        }
        public byte[] Substraction(byte[] firstBits, byte[] secondBits,int baseBits)
        {
            byte[] result = new byte[firstBits.Length];
            int remainder = 0;
            for (int i = 0; i < result.Length; i++)
            {
                int hold = (baseBits + (GetAt(firstBits, i) - GetAt(secondBits, i) - remainder));
                result[result.Length - 1 - i] = (byte)(hold % baseBits);
                remainder = (hold < baseBits) ? (byte)1 : (byte)0;
            }
            return result;
        }
        public byte[] Multiplication(byte[] firstBits, byte[] multipler,int baseBits)
        {
            byte[] holder = new byte[firstBits.Length];
          
                while (NotEqual(multipler, ToByteConversionAnyBase(0,2)))
                {
                    holder = Addition(holder, firstBits, baseBits);
                    multipler = Substraction(multipler, ToByteConversionAnyBase(1,baseBits), baseBits);
                }           

            return holder;
        }
        public byte[] Division(byte[] firstBits, byte[] divider,int baseBits)
        {          
            byte[] count = {0};

            while (LessThan(divider, firstBits))
            {
                firstBits = Substraction(firstBits, divider, baseBits);
                count = Addition(count, ToByteConversion(1), baseBits);
            }

            return count;

        }
        public bool GreaterThan(byte[] numberToCheck, byte[] numberToBeChecked)
        {
            return LessThan(numberToBeChecked, numberToCheck);
        }
        public bool Equal(byte[] numberToCheck, byte[] numberToBeChecked)
        {

            return (LessThan(numberToCheck, numberToBeChecked) && GreaterThan(numberToCheck, numberToBeChecked)) ? true : false;

        }
        public bool NotEqual(byte[] numberTocheck, byte[] numberToBeChecked)
        {        
            return !(Equal(numberToBeChecked,numberTocheck));
        }
        public int GetNoOfZeroes(byte[] bitsInserted)
        {
            int countZeroes = 0;

            for (int i = 0; i < bitsInserted.Length; i++)
            {

                if (GetAt(bitsInserted, i) ==(byte) 0)
                {
                    countZeroes++;
                }
                else if (GetAt(bitsInserted, i) != (byte)0)
                {
                    return countZeroes;
                }
            }
                return countZeroes;
        }
        public byte[] ToByteConversionAnyBase(int number,int baseBits)
        {
            byte[] bits = new byte[0];
            int i = 1;
            while (number != 0)
            {
                Array.Resize(ref bits, i);
                bits[i - 1] = (byte)(number % baseBits);
                i++;
                number = number / baseBits;
            }
            return ReverseBits(bits);
        }
    }
}


