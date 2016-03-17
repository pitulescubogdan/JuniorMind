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
            int index = 0;
            Assert.AreEqual(3, Calculate("+ 1 2",ref index));
        }
        [TestMethod]
        public void Substraction()
        {
            int index = 0;
            Assert.AreEqual(2, Calculate("- 5 3",ref index));

        }
        [TestMethod]
        public void CalculateMoreAdditions()
        {
            int index = 0;
            Assert.AreEqual(8, Calculate("+ + 1 2 + 2 3",ref index));
        }
        [TestMethod]
        public void Multiplication()
        {
            int index = 0;
            Assert.AreEqual(12, Calculate("* 3 4", ref index));
        }
        [TestMethod]
        public void Division()
        {
            int index = 0;
            Assert.AreEqual(4, Calculate("/ 12 3",ref index));

        }
        [TestMethod]
        public void MultipleOperations()
        {
            int index = 0;
            Assert.AreEqual(4, Calculate("* + 1 1 2",ref index));
        }

        public double Calculate(string inputString, ref int index)
        {
            string[] elements = inputString.Split(' '); 
            string firstElement = elements[index++];
            double number;
            

            if(Double.TryParse(firstElement,out number))
            {
                return number;
            }

            switch (firstElement)
            {
                case "+": return Calculate(inputString,ref index) + Calculate(inputString,ref index);
                case "*": return Calculate(inputString, ref index) * Calculate(inputString, ref index);
                case "/": return Calculate(inputString, ref index) / Calculate(inputString, ref index);
                default: return Calculate(inputString, ref index) - Calculate(inputString, ref index);
            }
        }
    }
}
