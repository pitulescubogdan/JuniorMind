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
            string[] result = { "positive", "A", "has", "person", "energy" };
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
        public void QuickSortTest()
        {
            string text = "A positive person has positive energy";
            string[] check = text.Split(' ');
            Word[] sentenceInfo = new Word[] {
                new Word("A",1),
                new Word("positive",2),
                new Word("person",1),
                new Word("has",1),
                new Word("positive",2),
                new Word("energy",1)
            };
            Word[] sortedWords = new Word[] {
                new Word("positive",2),
                new Word("positive",2),
                new Word("person",1),
                new Word("A",1),
                new Word("has",1),
                new Word("energy",1)
            };

            CollectionAssert.AreEqual(sortedWords, QuickSort(sentenceInfo));
        }
        [TestMethod]
        public void SentenceInformation()
        {
            string text = "A positive person has positive energy";
            string[] check = text.Split(' ');
            Word[] sentenceInfo = new Word[] {
                new Word("A",1),
                new Word("positive",2),
                new Word("person",1),
                new Word("has",1),
                new Word("positive",2),
                new Word("energy",1)
            };
            CollectionAssert.AreEqual(sentenceInfo, SetWordAndOccurences(check));
        }

        public struct Word
        {
            public string word;
            public int occurences;
            public Word(string word, int occurences)
            {
                this.word = word;
                this.occurences = occurences;
            }
        }
        public string[] OrdinateWords(string inputText)
        {
            string[] words = inputText.Split(' ');

            Word[] wordsInfo = SetWordAndOccurences(words);
            QuickSort(wordsInfo);
            return GetUniqueWords(wordsInfo);
        }

        private string[] GetUniqueWords(Word[] words)
        {
            string[] uniqueWords = new string[words.Length];
            int countCommon = 0;
            int k = 0;
            int length = words.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (words[i].word.Equals(uniqueWords[j]))
                    {
                        countCommon++;
                    }
                    else {
                        uniqueWords[k++] = words[j].word;
                        break;
                    }
                }
            }

            Array.Resize(ref uniqueWords, uniqueWords.Length - countCommon);
            return uniqueWords;
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
        public Word[] PlaceNumberAtACertainIndex(Word[] wordsInfo, int indexPlacement, int pivotIndex)
        {
            Word holder = wordsInfo[pivotIndex];
            for (int i = pivotIndex - 1; i >= indexPlacement; i--)
            {
                wordsInfo[i + 1] = wordsInfo[i];
            }
            wordsInfo[indexPlacement] = holder;

            return wordsInfo;
        }
        public Word[] QuickSort(Word[] words)
        {

            QuickSort(words, 0, words.Length - 1);
            return words;
        }
        public void QuickSort(Word[] words, int start, int end)
        {
            int l = start; int r = end;
            var pivot = words[(start + end) / 2].occurences;

            if (end - start < 0) return;
            if (l < r) SwapNumbers(words, l++, r--);
            if (start < r) QuickSort(words, start, r);
            if (l < end) QuickSort(words, l, end);

        }
        public void SwapNumbers(Word[] words, int indexReplaced, int indexToReplace)
        {
            var holder = words[indexToReplace];
            words[indexToReplace] = words[indexReplaced];
            words[indexReplaced] = holder;
        }
        public Word[] SetWordAndOccurences(string[] inputText)
        {
            Word[] wordAndOcc = new Word[inputText.Length];

            for (int i = 0; i < inputText.Length; i++)
            {
                wordAndOcc[i].word = inputText[i];
                wordAndOcc[i].occurences = GetOccurences(inputText, inputText[i]);
            }
            return wordAndOcc;
        }
    }
}
