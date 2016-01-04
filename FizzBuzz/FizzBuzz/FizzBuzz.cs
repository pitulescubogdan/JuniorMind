using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Fizz", CheckMultiple(12));
        }

        public string CheckMultiple(int NumberInserted)
        {
            string result = "";
            return result;
        }
    }
}
