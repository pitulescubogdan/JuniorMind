﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class Password
    {
        public struct Options
        {
            public int smallChars;
            public int noOfUpperChars;
            public int noOfNumbers;
            public int noOfSymbols;
            public bool notIncludedSimilarChars;
            public bool notIncludedAmbigueChars;

            public Options(int smallChars, int noOfUpperChars, int noOfNumbers, int noOfSymbols, bool notIncludedSimilarChars, bool notIncludedAmbigueChars)
            {
                this.smallChars = smallChars;
                this.noOfUpperChars = noOfUpperChars;
                this.noOfNumbers = noOfNumbers;
                this.noOfSymbols = noOfSymbols;
                this.notIncludedSimilarChars = notIncludedSimilarChars;
                this.notIncludedAmbigueChars = notIncludedAmbigueChars;
            }

        }
        [TestMethod]
        public void GetPasswordOfSmallCharacters()
        {
            var password = new Options(10, 0, 0, 0, false, false);
            Assert.AreEqual(true, CheckSmallLettersOfAString(GetPassword(password)));
        }
        
        [TestMethod]
        public void GetPasswordForSmallAndBigLetters()
        {
            var password = new Options(10, 4, 3, 0, true, false);
            Assert.AreEqual(10, CountChars(GetPassword(password)));
        }    
        [TestMethod]
        public void CheckForLowerAndUpperLetters()
        {
            Assert.AreEqual(true, CheckForLowerAndUpperLetters("AsfaSfSr"));
        }
        [TestMethod]
        public void RemoveChars()
        {
            Assert.AreEqual("afkaL234", RemoveChars("afkal1Lo01234"));
        }
        [TestMethod]
        public void RemoveAmbigueCharsTest()
        {
            Assert.AreEqual("assa", RemoveChars("{}assa[]()~", "{}[]()/\'~,;.<>"));
        }
        [TestMethod]
        public void ShuffleStringTest()
        {
            string checkString = "abcdefgh";
            Assert.AreEqual(CountChars(checkString), CountChars(ShuffleString(checkString)));
        }
        [TestMethod]
        public void GenerateSomeSymbols()
        {
            Assert.AreEqual(5, CountChars(GetString(5, ' ', '/' + 1,true)));
        }
        [TestMethod]
        public void GetPasswordWithAllOptions()
        {
            var password = new Options(10, 4, 3, 2, true, true);
            Assert.AreEqual(10, CountChars(GetPassword(password)));
        }
        Random rand = new Random();

        public string GetPassword(Options options)
        {
            string result = string.Empty;
            var smallChars = options.smallChars - options.noOfUpperChars - options.noOfNumbers - options.noOfSymbols;
            result += GetString(smallChars, 'a', 'z' + 1,options.notIncludedSimilarChars);
            result += GetString(options.noOfUpperChars,'A','Z'+1, options.notIncludedSimilarChars);
            result += GetString(options.noOfNumbers,0,9, options.notIncludedSimilarChars);
            result += GetString(options.noOfSymbols,' ','/'+1,options.notIncludedAmbigueChars,"{}[]()/\\'\"/~/,/;/./<> ");
           
            return ShuffleString(result);
        }

        public string GetString(int noOfSmallLetters, int startRange, int endRange, bool removeChars,string toRemove = "l1IoO0")
        {
            string output = string.Empty;

            while (noOfSmallLetters != 0)
            {
                char holdChar = (char)rand.Next(startRange,endRange);
                if(!removeChars)
                {
                    output = RemoveChars(output,toRemove);
                }
                output += holdChar;
                noOfSmallLetters--;

            }
            return output;
        }       
        public bool CheckSmallLettersOfAString(string inputString)
        {

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (!(char.IsLower(inputString[i]))) return false;
            }

            return true;
        }
        public int CountUpperLetters(string inputString)
        {
            int count = 0;
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if ((char.IsUpper(inputString[i]))) count++;
            }
            return count;
        }
        public bool CheckForLowerAndUpperLetters(string inputString)
        {
            return !(CheckSmallLettersOfAString(inputString) && (CountUpperLetters(inputString) > 0));
        }
        public int CountNumbers(string inputString)
        {
            int count = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                int nr = (int)Char.GetNumericValue(inputString[i]);
                if (nr >= 0 && nr <= 9)
                {
                    count++;
                }
            }

            return count;
        }
        public int CountChars(string inputString)
        {
            int count = 0;
            foreach (char x in inputString.ToCharArray())
            {
                count++;
            }
            return count;
        }
        public string RemoveChars(string inputString, string charsToRemove = "l1IoO0")
        {
            string result = string.Empty;
            foreach (char c in inputString)
            {
                if (!charsToRemove.Contains(c.ToString())) result += c;
            }
            return result;
        }      
        public string ShuffleString(string inputString)
        {
            char[] charsFromString = inputString.ToCharArray();
            Random rend = new Random();
            int counter = inputString.Length;
            string result = string.Empty;
            while (counter > 0)
            {
                counter--;
                int k = rend.Next(counter + 1);
                var hold = charsFromString[k];
                charsFromString[k] = charsFromString[counter];
                charsFromString[counter] = hold;
                result += hold;
            }
            return result;
        }     
    }
}
