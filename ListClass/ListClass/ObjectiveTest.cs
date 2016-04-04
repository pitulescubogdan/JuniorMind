using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListClass
{
    [TestClass]
    public class ObjectiveTest
    {
        [TestMethod]
        public void TestCount()
        {
            List<string> objectOne = new List<string>();

            Assert.AreEqual(0, objectOne.Count);

        }

    }
}
