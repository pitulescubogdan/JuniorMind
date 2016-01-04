using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestForFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", CheckMultiple(15));
        }
        [TestMethod]
        public void TestForFizz()
        {
            Assert.AreEqual("Fizz", CheckMultiple(9));
        }
        [TestMethod]
        public void TestForBuzz()
        {
            Assert.AreEqual("Buzz", CheckMultiple(10));
        }

        public string CheckMultiple(int NumberInserted)
        {
            string result = "";
            if(NumberInserted % 3 ==0 && NumberInserted % 5 == 0)
            {
                result = "FizzBuzz";
            }
            else if(NumberInserted % 3 == 0)
            {
                result = "Fizz";
            }else if(NumberInserted % 5 == 0)
            {
                result = "Buzz";
            }

            return result;
        }
    }
}
