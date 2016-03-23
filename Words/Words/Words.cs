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
        [TestMethod]
        public void Occurences()
        {
            string text = "A positive person has positive energy";
            Assert.AreEqual(2, GetOccurences(text, "positive"));
        }

        public string[] OrdinateWords(string inputText)
        {
            string[] words = inputText.Split(' ');

            

            return new string[] { "empty" };
        }
        public int GetOccurences(string inputArray, string wordToSearch)
        {
            int count = 0;
            string[] words = inputArray.Split(' ');
            for(int i =0;i<words.Length;i++)
            {
                if (wordToSearch == words[i]) count++;
            }
            return count;
        }
    }
}
