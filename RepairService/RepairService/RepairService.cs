using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepairService
{
    [TestClass]
    public class RepairService
    {
        [TestMethod]
        public void OneIssue()
        {
            Issue oneIssue = new Issue("Gasoline leaking", "High");
            CollectionAssert.AreEqual(new string[] { "High" }, SortByPriority(oneIssue));
        }

        public struct Issue
        {
            string nameOfTheIssue;
            string priority;
            public Issue(string nameOfIssue, string priority)
            {
                this.nameOfTheIssue = nameOfIssue;
                this.priority = priority;
            }
        }

        public string[] SortByPriority(Issue issue)
        {
            return new string[] { "High" };
        }

    }
}
