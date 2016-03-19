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
            Issue[] issues = new Issue[] { new Issue("Gasoline leaking", "High"),
                new Issue("Tire change","Low") };

            Assert.AreEqual(issues[0], SortByPriority(issues));
        }
        [TestMethod]
        public void FourIssues()
        {
            Issue[] issues = new Issue[] {
            new Issue("Cleaning","Low"),
            new Issue("Painting","Medium"),
            new Issue("Direction broken","High") };

            Assert.AreEqual(issues[2], SortByPriority(issues));
        }

        public struct Issue
        {
            public string nameOfTheIssue;
            public string priority;
            public Issue(string nameOfIssue, string priority)
            {
                this.nameOfTheIssue = nameOfIssue;
                this.priority = priority;
            }
        }

        public Issue SortByPriority(Issue[] issue)
        {
            Issue highestPriority = issue[0];
            for (int i = 1; i < issue.Length; i++)
            {
                highestPriority = (GetPriority(issue[i - 1]) > GetPriority(issue[i])) ? issue[i - 1] : issue[i];
            }
            return highestPriority;
        }
        public int GetPriority(Issue issue)
        {
            string priority = issue.priority;
            switch (priority)
            {
                case "High": return 3;
                case "Medium": return 2;
                default: return 1;
            }
        }
    }
}
