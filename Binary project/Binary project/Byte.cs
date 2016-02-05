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
        public void TestGetAT()
        {
            Assert.AreEqual(0, GetAt(ToByteConversion(2), 4));
        }
        [TestMethod]
        public void AdditionBinary()
        {
            CollectionAssert.AreEqual(new byte[] {1, 1, 0 , 0},Addition(ToByteConversion(6),ToByteConversion(6)));
        }
        [TestMethod]
        public void SubstractionBinary()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, Substraction(ToByteConversion(14), ToByteConversion(4))); 
        }
        [TestMethod]
        public void Multiplication()
        {
            CollectionAssert.AreEqual(new byte[] {0, 1, 1, 0 }, Multiplication(ToByteConversion(3),ToByteConversion(2)));            
        }
        [TestMethod]
        public void MultiplicationWithGreaterNumbers()
        {
            CollectionAssert.AreEqual(new byte[] {1, 1, 0, 0 }, Multiplication(ToByteConversion(3),ToByteConversion(4)));                       
        }
        [TestMethod]
        public void MultiplicationThreeTimesFive()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1 }, Multiplication(ToByteConversion(5),ToByteConversion(3)));                       
            
        }
        [TestMethod]
        public void DivisionBinary()
        {
            CollectionAssert.AreEqual(new byte[] {0,0,1,1}, Division(ToByteConversion(12),ToByteConversion(4)));                       
            
        }
        [TestMethod]
        public void DivisionBetween15and3()
        {
            CollectionAssert.AreEqual(new byte[] {0,1,0,1}, Division(ToByteConversion(15),ToByteConversion(3)));                       
            
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
        public byte[] Addition(byte[] firstBits, byte[] secondBits)
        {
            byte[] result = new byte[0];
            Array.Resize(ref result, (Math.Max(firstBits.Length, secondBits.Length) + 4 - Math.Max(firstBits.Length, secondBits.Length)));
            int remainder = 0;
            int k = result.Length - 1;
            for (int i = 0; i < result.Length; i++)
            {
                int hold = GetAt(firstBits, i) + GetAt(secondBits, i) + remainder;
                result[k] = (byte)(hold % 2);
                remainder = hold / 2;               
                k--;
            }
            return result;
        }
        public byte[] Substraction(byte[] firstBits, byte[] secondBits)
        {
            byte[] result = new byte[firstBits.Length];
            int remainder = 0;
            int k = result.Length - 1;
            for (int i = 0; i < result.Length; i++)
            {              
                int hold =  2 + (GetAt(firstBits, i) - GetAt(secondBits, i) - remainder);
                result[k] = (byte)(hold % 2);
                remainder = (hold < 2) ? (byte)1 : (byte)0;
                k--;
            }
            return result;
        }
        public byte[] Multiplication(byte[] firstBits, byte[] multipler)
        {
            byte[] holder = new byte[firstBits.Length + 4 - (firstBits.Length % 4)];
            double counter = ToDecimalConvert(multipler);

            if(ToDecimalConvert(multipler) > 2){
                while ((counter) != 0)
                {
                    holder = Addition(holder, firstBits);
                    counter--;
                }
            }else if(ToDecimalConvert(multipler) == 2)
            {
                return holder = Addition(firstBits, firstBits);
            }
            else if(ToDecimalConvert(multipler) == 1)
            {                             
                return firstBits;
            }

            return holder;
        }
        public byte[] Division(byte[] firstBits, byte[] divider)
        {
            int counter = (int)(ToDecimalConvert(divider) - 1);
            int eachDivider = (int)(ToDecimalConvert(firstBits) / ToDecimalConvert(divider));
            if (ToDecimalConvert(divider) > 2)
            {
                while (counter != 0)
                {
                    firstBits = Substraction(firstBits, ToByteConversion(eachDivider));                 
                    counter--;
                }
            }
            else if (ToDecimalConvert(divider) == 2)
            {
                return firstBits = Substraction(firstBits, divider);
            }
            else if (ToDecimalConvert(divider) == 1)
            {
                return firstBits;
            }
            return firstBits;
        }
        public bool GreaterThan(byte[] numberToCheck, byte[] numberToBeChecked)
        {
            bool result = true;
            for (int i = 0; i < Math.Max(numberToBeChecked.Length, numberToCheck.Length); i++)
            {
                result = (GetAt(numberToCheck, i) > GetAt(numberToBeChecked, i)) ? true : false;
            }
            return result;
        }
        public bool Equal(byte[] numberToCheck, byte[] numberToBeChecked)
        {
            bool result = false;
            for (int i = 0; i < Math.Max(numberToBeChecked.Length, numberToCheck.Length); i++)
            {
                while (GetAt(numberToCheck, i) == GetAt(numberToBeChecked, i))
                {
                    result =  true;
                    break;
                }
                return result;
            }
            return result;
        }
        public bool NotEqual(byte[] numberTocheck, byte[] numberToBeChecked)
        {        
            return !(Equal(numberToBeChecked,numberTocheck));
        }
    }
}


