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
            string[] result = { "positive", "positive", "A", "person", "has", "energy" };
            CollectionAssert.AreEqual(result, OrdinateWords("A positive person has positive energy"));
        }
        [TestMethod]
        public void Occurences()
        {
            string text = "A positive person has positive energy";
            string[] check = text.Split(' ');
            Assert.AreEqual(2, GetOccurences(check, "positive"));
        }

        public string[] OrdinateWords(string inputText)
        {
            string[] words = inputText.Split(' ');
            int length = words.Length;
            while (length != 0)
            {
                for (int i = 1; i < length; i++)
                {
                    if (GetOccurences(words, words[i - 1]) < GetOccurences(words, words[i])) Swap(words, i - 1, i);
                }
                length--;
            }
            return words;
        }
        public int GetOccurences(string[] inputText, string wordToSearch)
        {
            int count = 0;
            for (int i = 0; i < inputText.Length; i++)
            {
                if (wordToSearch == inputText[i]) count++;
            }
            return count;
        }
        public void Swap(string[] text, int indexToReplace, int indexReplacement)
        {
            var holder = text[indexToReplace];
            text[indexToReplace] = text[indexReplacement];
            text[indexReplacement] = holder;
        }
    }
}
