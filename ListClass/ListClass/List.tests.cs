using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace List
{
    [TestClass]
    public class List
    {
        [TestMethod]    
        public void ListCount()
        {
            List<string> objectOne = new List<string>();

            Assert.AreEqual(0, objectOne.Count);
        }
        [TestMethod]
        public void ListAdd()
        {
            List<int> objectOne = new List<int>();
            objectOne.Add(2);
            Assert.IsTrue(objectOne.Contains(2));
        }
        
    }
}
