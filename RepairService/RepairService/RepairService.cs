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
            Issue[] issues = new Issue[] { new Issue("Gasoline leaking", Priority.High),
                new Issue("Tire change",Priority.Low) };

            CollectionAssert.AreEqual(issues, SortByPriority(issues));
        }
        [TestMethod]
        public void FourIssues()
        {
            Issue[] issues = new Issue[] {
            new Issue("Cleaning",Priority.Low),
            new Issue("Painting",Priority.Medium),
            new Issue("Direction broken",Priority.High) };

            Issue[] sortedServices = new Issue[] {
            new Issue("Direction broken",Priority.High),
            new Issue("Painting",Priority.Medium),
            new Issue("Cleaning",Priority.Low) };

            CollectionAssert.AreEqual(sortedServices, SortByPriority(issues));
        }
        [TestMethod]
        public void SamePriority()
        {
            Issue[] issues = new Issue[] {
            new Issue("Cleaning",Priority.High),
            new Issue("Change leather",Priority.High),
            };

            CollectionAssert.AreEqual(issues, SortByPriority(issues));
        }

        public struct Issue
        {
            public string nameOfTheIssue;
            public Priority priority;
            public Issue(string nameOfIssue, Priority priority)
            {
                this.nameOfTheIssue = nameOfIssue;
                this.priority = priority;
            }
        }
        public enum Priority
        {
            Low = 1,
            Medium = 2,
            High = 3
        }

        public Issue[] SortByPriority(Issue[] issue)
        {
            int no = issue.Length;
            while (no != 0)
            {
                for (int i = 1; i < issue.Length; i++)
                {
                    if (issue[i - 1].priority < issue[i].priority) Swap(issue, i, i - 1);
                }
                no--;
            }

            return issue;
        }
        public void Swap(Issue[] issue, int indexToReplace, int indexReplacement)
        {
            var holder = issue[indexToReplace];
            issue[indexToReplace] = issue[indexReplacement];
            issue[indexReplacement] = holder;
        }

    }
}
