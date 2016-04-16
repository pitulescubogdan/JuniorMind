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
            string[] result = { "positive", "person", "has", "A", "energy" };
            CollectionAssert.AreEqual(result, OrdinateWords("A positive person has positive energy"));
        }
        [TestMethod]
        public void BigText()
        {
            string[] result = { "it", "your", "mind", "believes", "then", "", "", "", "", "", "" };
            string text = "if your mind believes it then your body can do it so believe it";
            CollectionAssert.AreEqual(result, OrdinateWords(text));
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
                new Word("has",1),
                new Word("A",1),
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
            string[] uniqueWords = { "" };
            int length = words.Length;
            int k = 0;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < uniqueWords.Length; j++)
                {
                    if (!(words[i].word.Equals(uniqueWords[j])))
                    {
                        uniqueWords[k++] = words[i].word;
                        Array.Resize(ref uniqueWords, uniqueWords.Length + 1);
                        break;
                    }
                    else if (words[i].word.Equals(uniqueWords[j]))
                    {
                        break;
                    }
                }
            }
            Array.Resize(ref uniqueWords, uniqueWords.Length - 1);
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

            if (words.Length <= 1) return;
            if (start < end)
            {
                var pivot = Partitioning(words, start, end);
                QuickSort(words, start, pivot - 1);
                QuickSort(words, pivot + 1, end);
            }
        }
        public int Partitioning(Word[] words, int left, int right)
        {
            int pivot = right;
            int k = left - 1;

            for (int j = left; j < right; j++)
            {
                if (words[j].occurences >= words[pivot].occurences) SwapNumbers(words, ++k, j);
            }

            SwapNumbers(words, pivot, k + 1);
            return k + 1;

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
