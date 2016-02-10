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
            var password = new Options[] { new Options(10, 4, 0, 0, false, false) };
            Assert.AreEqual("asd", (GetPassword(password)));
        }
        [TestMethod]
        public void CheckForBigLetters()
        {
            var bigPassword = GetBigLetters(5);
            Assert.AreEqual(true, CheckUpperLetters(bigPassword));
            
        }
        [TestMethod]
        public void CheckForLowerAndUpperLetters()
        {
            Assert.AreEqual(true, CheckForLowerAndUpperLetters("AsfaSfSr"));
        }

        public string GetPassword(Options[] options)
        {
            string result = string.Empty;
            for (int i = 0; i < options.Length; i++)
            {
                result = GetSmallLetters(options[i].smallChars - options[i].noOfUpperChars);
                result += GetBigLetters(options[i].noOfUpperChars);
            }
            return  result;
        }
        public string GetSmallLetters(int noOfSmallLetters)
        {
            string output = string.Empty;
            Random rand = new Random();

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
        public bool CheckSmallLettersOfAString(string inputString)
        {

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (!(char.IsLower(inputString[i]))) return false;
            }

            return true;
        }
        public bool CheckUpperLetters(string inputString)
        {

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if ((!(char.IsUpper(inputString[i])))) return false;
            } 
                return true;
        }
        public bool CheckForLowerAndUpperLetters(string inputString)
        {
            return (CheckSmallLettersOfAString(inputString) && CheckUpperLetters(inputString)) ? false : true;
        }
        
    }
}
