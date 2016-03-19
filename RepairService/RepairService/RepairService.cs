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

            Assert.AreEqual(issues[0], SortByPriority(issues));
        }
        [TestMethod]
        public void FourIssues()
        {
            Issue[] issues = new Issue[] {
            new Issue("Cleaning",1),
            new Issue("Painting",2),
            new Issue("Direction broken",3) };

            Assert.AreEqual(issues[2], SortByPriority(issues));
        }
        [TestMethod]
        public void SamePriority()
        {
            Issue[] issues = new Issue[] {
            new Issue("Cleaning",1),
            new Issue("Change leather",1),
            };

            Assert.AreEqual(issues[1], SortByPriority(issues));
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

        public Issue SortByPriority(Issue[] issue)
        {
            int length = issue.Length;
            Issue highestPriority = issue[0];
            while (length != 0)
            {
                for (int i = 1; i < issue.Length; i++)
                {
                    highestPriority = (issue[i - 1].priority > issue[i].priority) ? issue[i - 1] : issue[i];
                }
                length--;
            }
            return highestPriority;
        }
        

    }
}
