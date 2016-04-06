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
            List<int> objectOne = new List<int>();
            objectOne.Add(34);
            objectOne.Add(55);
            Assert.AreEqual(2, objectOne.Count);
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
