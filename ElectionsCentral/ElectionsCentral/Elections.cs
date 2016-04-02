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
            Sections[] sections = new Sections[]
            {
                new Sections(1,new Candidates[] {
                    new Candidates("Bogdan",500),
                    new Candidates("George", 400)
                }),
                new Sections(2,new Candidates[]
                {
                    new Candidates("George",550),
                    new Candidates("Bogdan",500)
                })
            };

            CollectionAssert.AreEqual(new Candidates[] {
                new Candidates("Bogdan", 1000),
                new Candidates("George", 950) },
                GetElections(sections));
        }
        [TestMethod]
        public void SortCandidates()
        {
            var list = new Candidates[] {
                new Candidates("Bog",100),
                new Candidates("Mih",200),
                new Candidates("Dan",94)
            };
            var sorted = new Candidates[]
            {
                new Candidates("Bog",100),
                new Candidates("Dan",94),
                new Candidates("Mih",200)
            };
            CollectionAssert.AreEqual(sorted, SortCandidates(list));
        }
        [TestMethod]
        public void MixAllVotes()
        {
            Sections[] sections = new Sections[]
            {
                new Sections(1,new Candidates[] {
                    new Candidates("Bogdan",500),
                    new Candidates("George", 400)
                }),
                new Sections(2,new Candidates[]
                {
                    new Candidates("George",550),
                    new Candidates("Bogdan",500)
                })
            };
            var result = new Sections[]
            {
               new Sections(100, new Candidates[]
                {
                    new Candidates("George",550),
                    new Candidates("Bogdan",500),
                    new Candidates("Bogdan",500),
                    new Candidates("George", 400)
                }) };

            CollectionAssert.AreEqual(result, CombineAllElections(sections));
        }

        public struct Candidates
        {
            public string name;
            public int noOfVotes;
            public Candidates(string name, int votes)
            {
                this.name = name;
                this.noOfVotes = votes;
            }
        }
        public struct Sections
        {
            public int section;
            public Candidates[] candidates;
            public Sections(int section, Candidates[] candidates)
            {
                this.section = section;
                this.candidates = candidates;
            }
        }
        public Sections[] GetElections(Sections[] sectionsLists)
        {
            return sectionsLists;
        }
        public Sections[] CombineAllElections(Sections[] lists)
        {
            Sections[] allVotes = new Sections[lists.Length * lists[0].candidates.Length];
            allVotes[0].section = 100;
            for (int i = 0; i < lists.Length; i++)
            {
                int k = 0;
                Array.Copy(lists[i].candidates, k, allVotes, lists[i].candidates.Length - 1, lists[i].candidates.Length);
                k = lists[i + 1].candidates.Length - 1;
            }
            return allVotes;
        }
        public Candidates[] SortCandidates(Candidates[] canditates)
        {
            for (int i = 0; i < canditates.Length - 1; i++)
            {
                int k = i + 1;
                while (k > 0)
                {
                    if (canditates[k-1].name[0] > canditates[k].name[0]) SwapCandidates(canditates, k);

                    k--;
                }
            }
            return canditates;
        }


        private static void SwapCandidates(Candidates[] canditates, int k)
        {
            var temp = canditates[k - 1];
            canditates[k - 1] = canditates[k];
            canditates[k] = temp;
        }
    }
}
