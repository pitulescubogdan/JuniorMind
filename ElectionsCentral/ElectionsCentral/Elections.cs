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
                    new Candidates("George",400)
                }),
                new Sections(2,new Candidates[]
                {
                    new Candidates("George",550),
                    new Candidates("Bogdan",500)
                })
            };

            CollectionAssert.AreEqual(new Candidates[] {
                new Candidates("Bogdan",1000),
                new Candidates("George",950),
            },
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
            CollectionAssert.AreEqual(sorted, SortAlphabetical(list));
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
            var result = new Candidates[]
                {
                    new Candidates("Bogdan",500),
                    new Candidates("Bogdan",500),
                    new Candidates("George",400),
                    new Candidates("George", 550)
                };

            CollectionAssert.AreEqual(result, CombineAllElections(sections));
        }
        [TestMethod]
        public void SortCandidatesByVotes()
        {
            var list = new Candidates[] {
                new Candidates("Bog",100),
                new Candidates("Mih",200),
                new Candidates("Dan",94)
            };
            var sorted = new Candidates[]
            {
                new Candidates("Mih",200),
                new Candidates("Bog",100),
                new Candidates("Dan",94)
            };
            CollectionAssert.AreEqual(sorted, SortByVotes(list));
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
        public Candidates[] GetElections(Sections[] sectionsLists)
        {

            var finalList = CombineAllElections(sectionsLists);
            return SortByVotes(CalculateVotes(finalList));
        }
        public Candidates[] CombineAllElections(Sections[] sections)
        {
            int noOfCandidates = sections[0].candidates.Length;
            var list = new Candidates[noOfCandidates * sections.Length];
            int arrayLength = 0;

            for (int i = 0; i < sections.Length; i++)
            {
                sections[i].candidates.CopyTo(list, arrayLength);
                arrayLength += noOfCandidates;
            }

            return SortAlphabetical(list);
        }

        public Candidates[] CalculateVotes(Candidates[] candidates)
        {
            int index = 0;
            int countCommon = 1;
            Candidates[] finalList = new Candidates[countCommon];
            for (int j = 0; j <= countCommon; j++)
                for (int i = j + 1; i < candidates.Length; i++)
                {
                    if (candidates[j].name.Equals(candidates[i].name))
                    {
                        candidates[j].noOfVotes += candidates[i].noOfVotes;
                        finalList[index++] = candidates[j];
                        Array.Resize(ref finalList, ++countCommon);
                    }
                }
            Array.Resize(ref finalList, finalList.Length - 1);
            return SortByVotes(finalList);
        }

        public int GetUniqueCandidatesLength(Candidates[] list)
        {
            return list.Length;
        }
        public Candidates[] SortAlphabetical(Candidates[] canditates)
        {
            for (int i = 0; i < canditates.Length - 1; i++)
            {
                int k = i + 1;
                while (k > 0)
                {
                    if (canditates[k - 1].name[0] > canditates[k].name[0]) SwapCandidates(canditates, k);

                    k--;
                }
            }
            return canditates;
        }

        public Candidates[] SortByVotes(Candidates[] canditates)
        {
            for (int i = 0; i < canditates.Length - 1; i++)
            {
                int k = i + 1;
                while (k > 0)
                {
                    if (canditates[k - 1].noOfVotes < canditates[k].noOfVotes) SwapCandidates(canditates, k);

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
