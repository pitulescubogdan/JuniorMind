using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Words
{
    [TestClass]
    public class Words
    {
        [TestMethod]
        public void ArrangedWords()
        {
            CollectionAssert.AreEqual(new string[]{ "empty" }, OrdinateWords("A positive person has positive energy"));
        }
        public string[] OrdinateWords(string inputText)
        {

            return new string[] { "empty" };
        }
    }
}
