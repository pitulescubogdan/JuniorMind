using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectionsCentral
{
    [TestClass]
    public class Elections
    {
        [TestMethod]
        public void CentraliseElections()
        {
            Candidates[] list = new Candidates[]
            {
                new Candidates("Bogdan",100)
            };
            CollectionAssert.AreEqual(list, GetElections(list));
        }

        public struct Candidates
        {
            string name;
            int noOfVotes;
            public Candidates(string name, int votes)
            {
                this.name = name;
                this.noOfVotes = votes;
            }
        }
        public Candidates[] GetElections(Candidates[] candidates)
        {
            return candidates;
        }
    }
}
