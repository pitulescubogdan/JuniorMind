using System;
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
            var password = new Options[] { new Options(10, 0, 0, 0, false, false) };
            Assert.AreEqual(true, CheckSmallLettersOfAString(GetPassword(password)));
        }
        [TestMethod]
        public void CheckSmallLetters()
        {
            var smallPassowrd = GetSmallLetters(5);
            Assert.AreEqual(true, CheckSmallLettersOfAString(smallPassowrd));
        }
        [TestMethod]
        public void GetPasswordForSmallAndBigLetters()
        {
            var password = new Options[] { new Options(10, 4, 3, 0, true, false) };
            Assert.AreEqual(10, CountChars(GetPassword(password)));
        }
        [TestMethod]
        public void CheckForBigLetters()
        {
            var bigPassword = GetBigLetters(5);
            Assert.AreEqual(5, CountChars(bigPassword));

        }
        [TestMethod]
        public void CheckForLowerAndUpperLetters()
        {
            Assert.AreEqual(true, CheckForLowerAndUpperLetters("AsfaSfSr"));
        }
        [TestMethod]
        public void GetNumbersInPassword()
        {
            Assert.AreEqual(5, CountChars(GetNumbers(5)));
        }
        [TestMethod]
        public void RemoveChars()
        {
            Assert.AreEqual("afkaL234", RemoveChars("afkal1Lo01234"));
        }
        [TestMethod]
        public void RemoveAmbigueCharsTest()
        {
            Assert.AreEqual("assa", RemoveAmbigueChars("{}assa[]()~"));
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
            Assert.AreEqual(CountChars(GenerateSymbols(5)), CountChars(GenerateSymbols(5)));
        }
        Random rand = new Random();

        public string GetPassword(Options[] options)
        {
            string result = string.Empty;
            int smallChars = 0;
            int upperChars = 0;
            int numberChars = 0;

            for (int i = 0; i < options.Length; i++)
            {
                while (options[i].smallChars != result.Length)
                {
                    smallChars = options[i].smallChars - options[i].noOfUpperChars - options[i].noOfNumbers;
                    upperChars = options[i].noOfUpperChars;
                    numberChars = options[i].noOfNumbers;
                    if (!(options[i].notIncludedAmbigueChars) && !(options[i].notIncludedSimilarChars))
                    {
                        while (result.Length != options[i].smallChars)
                        {
                            result = GetSmallLetters(smallChars) + GetBigLetters(upperChars) + GetNumbers(numberChars);
                            result = RemoveChars(result);
                        }
                    }
                    else if (options[i].notIncludedSimilarChars && options[i].notIncludedAmbigueChars)
                    {
                        result = GetSmallLetters(smallChars) + GetBigLetters(upperChars) + GetNumbers(numberChars);
                        result = RemoveAmbigueChars(result);
                        result = RemoveChars(result);
                    }
                    else if (options[i].notIncludedSimilarChars && !(options[i].notIncludedAmbigueChars))
                    {
                        result = GetSmallLetters(smallChars) + GetBigLetters(upperChars) + GetNumbers(numberChars);
                        result = RemoveChars(result);
                    }
                    else
                    {
                        result = GetSmallLetters(smallChars) + GetBigLetters(upperChars) + GetNumbers(numberChars);
                        result = RemoveAmbigueChars(result);
                    }
                }
            }
            return ShuffleString(result);
        }

        public string GetSmallLetters(int noOfSmallLetters)
        {
            string output = string.Empty;

            while (noOfSmallLetters != 0)
            {
                int randomNumber = rand.Next(0, 26);
                char holdChar = (char)('a' + randomNumber);
                output += holdChar;
                noOfSmallLetters--;
            }
            return output;
        }
        public string GetBigLetters(int noOfLetters)
        {
            string output = GetSmallLetters(noOfLetters);

            return output.ToUpper();
        }
        public string GetNumbers(int noOfNumbers)
        {
            int holder = 0;
            string output = string.Empty;

            while (noOfNumbers != 0)
            {
                holder = rand.Next(0, 9);
                output += holder;
                noOfNumbers--;
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
            return (CheckSmallLettersOfAString(inputString) && (CountUpperLetters(inputString) > 0)) ? false : true;
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
        public string RemoveChars(string inputString,string charsToRemove = "l1IoO0")
        {
            string result = string.Empty;
            foreach(char c in inputString)
            {
                if (!charsToRemove.Contains(c.ToString())) result += c;             
            }
            return result;
        }
        public string RemoveAmbigueChars(string inputString)
        {           
            return RemoveChars(inputString, "{}[]()/\'~,;.<> ");
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
        
        public string GenerateSymbols(int numberOfSymbols)
        {
            int holder;
            string output = string.Empty;

            while(numberOfSymbols != 0)
            {
                holder = rand.Next(' ', '/');
                output += (char)holder;
                numberOfSymbols--;
            }
            return output;
        }
    }
}
