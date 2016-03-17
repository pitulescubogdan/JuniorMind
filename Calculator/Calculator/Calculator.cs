using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void CalculateOnePlusTwo()
        {
            Assert.AreEqual(3, Calculate("+ 1 2"));
        }
        [TestMethod]
        public void Substraction()
        {
            Assert.AreEqual(2, Calculate("- 5 3"));

        }
        [TestMethod]
        public void CalculateMoreAdditions()
        {
            Assert.AreEqual(8, Calculate("+ 1 2 + 2 3"));

        }
        public double Calculate(string inputString)
        {
            string[] elements = inputString.Split(' ');
            string firstElement = elements[0];
            double number;

            if(Double.TryParse(elements[0],out number))
            {
                return number;
            }

            switch (firstElement)
            {
                case "+": return Calculate(elements[1]) + Calculate(elements[2]);
                default: return Calculate(elements[1]) - Calculate(elements[2]);
            }
        }
    }
}
