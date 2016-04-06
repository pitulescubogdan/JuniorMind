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
        [TestMethod]
        public void ListClear()
        {
            List<int> obj = new List<int>();
            obj.Add(22);
            obj.Add(147);
            obj.Clear();
            Assert.AreEqual(0,obj.Count);
        }
        [TestMethod]
        public void ListIndexOf()
        {
            List<int> obj = new List<int>();
            obj.Add(1);
            obj.Add(2);
            obj.Add(3);
            obj.Add(5);
            Assert.AreEqual(3, obj.IndexOf(5));
        }
    }
}
