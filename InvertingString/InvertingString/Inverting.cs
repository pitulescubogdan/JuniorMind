using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvertingString
{
    [TestClass]
    public class Inverting
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            Assert.AreEqual("cba", ReverseString("abc"));
        }
        [TestMethod]
        public void RecursiveBiggerStringer()
        {
            Assert.AreEqual("tulaS", ReverseString("Salut"));
        }
        [TestMethod]
        public void ReverseSentence()
        {
            Assert.AreEqual("!asaomurf iz o etse izatsA", ReverseString("Astazi este o zi frumoasa!"));

        }

        public string ReverseString(string inputString)
        {
            if(inputString.Length == 0)
            {
                return inputString;
            }
            return inputString[inputString.Length - 1] + ReverseString(inputString.Substring(0, inputString.Length - 1));
        }
    }
}
