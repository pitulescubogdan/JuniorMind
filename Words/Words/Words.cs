using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
        [TestMethod]
        public void CheckUniqueWords()
        {
            string text = "da da nu nu si";

            Assert.AreEqual("da", UniqueWords(text.Split(' ')));
        }
        [TestMethod]
        public void QuickSortTest()
        {
            int[] numbers = { 6, 5, 2, 1, 8 };
            CollectionAssert.AreEqual(new int[] { 6, 2, 5, 1, 8 }, PlaceNumberAtACertainIndex(numbers, 1,2));
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
        public string UniqueWords(string[] inputText)
        {
            string[] storeUniqueWords = new string[inputText.Length];

            for (int i = 0; i < inputText.Length; i++)
            {

            }
            return "";
        }
        public int[] PlaceNumberAtACertainIndex(int[] numbers, int indexPlacement,int pivotIndex)
        {
            int holder = numbers[pivotIndex];
            for (int i = numbers.Length / 2 - 1; i >= indexPlacement; i--)
            {
                numbers[i + 1] = numbers[i];
            }
            numbers[indexPlacement] = holder;

            return numbers;
        }
    }
}
