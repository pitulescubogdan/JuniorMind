using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class Panagram
    {
        [TestMethod]
        public void CheckIfPanagram()
        {
            Assert.AreEqual("YES", CheckForPanagram("The"));
        }
        public string CheckForPanagram(string sentenceInserted)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'm', 'n' ,'o','p','q','r','s','t','u','v','w','x','y','z'};

            string senteLowerCase = sentenceInserted.ToLower();

           for(int i = 0; i < senteLowerCase.Length; i++)
            {
                if(alphabet[i].Equals)
            }

            return "NO";
        }
    }
}
