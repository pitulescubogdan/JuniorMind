using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepairService
{
    [TestClass]
    public class RepairService
    {
        [TestMethod]
        public void TwoIssues()
        {
            Issue[] issues = new Issue[] { new Issue("Gasoline leaking", 3),
                new Issue("Tire change",1) };

            CollectionAssert.AreEqual(issues, SortByPriority(issues));
        }
        [TestMethod]
        public void FourIssues()
        {
            Issue[] issues = new Issue[] {
            new Issue("Cleaning",1),
            new Issue("Painting",2),
            new Issue("Direction broken",3) };

            Issue[] sortedServices = new Issue[] {
            new Issue("Direction broken",3),
            new Issue("Painting",2),
            new Issue("Cleaning",1) };

            CollectionAssert.AreEqual(sortedServices, SortByPriority(issues));
        }
        [TestMethod]
        public void SamePriority()
        {
            Issue[] issues = new Issue[] {
            new Issue("Cleaning",1),
            new Issue("Change leather",1),
            };

            CollectionAssert.AreEqual(issues, SortByPriority(issues));
        }

        public struct Issue
        {
            public string nameOfTheIssue;
            public int priority;
            public Issue(string nameOfIssue, int priority)
            {
                this.nameOfTheIssue = nameOfIssue;
                this.priority = priority;
            }
        }

        public Issue[] SortByPriority(Issue[] issue)
        {
            int length = issue.Length;
            while (length != 0)
            {
                for (int i = 1; i < issue.Length; i++)
                {
                    if(issue[i - 1].priority < issue[i].priority)
                    {
                        Issue hold = issue[i - 1];
                        issue[i - 1] = issue[i];
                        issue[i] = hold;
                    }
                }
                length--;
            }
            return issue;
        }
        

    }
}
