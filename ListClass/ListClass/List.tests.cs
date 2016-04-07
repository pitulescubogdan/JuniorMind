using System;
using Xunit;

namespace List
{
    public class List
    {
        [Fact]
        public void ListCount()
        {
            List<int> objectOne = new List<int>();
            objectOne.Add(34);
            objectOne.Add(55);
            Assert.Equal(2, objectOne.Count);
        }
        [Fact]
        public void ListAdd()
        {
            List<int> objectOne = new List<int>();
            objectOne.Add(2);
            Assert.True(objectOne.Contains(2));
        }
        [Fact]
        public void ListClear()
        {
            List<int> obj = new List<int>();
            obj.Add(22);
            obj.Add(147);
            obj.Clear();
            Assert.Equal(0, obj.Count);
        }
        [Fact]
        public void ListIndexOf()
        {
            List<int> obj = new List<int>
            {
                1,2,3,5
            };
            Assert.Equal(3, obj.IndexOf(5));
        }
        [Fact]
        public void ListInsert()
        {
            List<int> obj = new List<int>
            {
                10,10,10,10,10
            };

            obj.Insert(5, 20);
            Assert.True(obj.Contains(20));
        }
        [Fact]
        public void ListRemoveAt()
        {
            List<int> obj = new List<int>();
            obj.Add(10);
            obj.Add(50);
            obj.RemoveAt(1);
            Assert.False(obj.Contains(50));
        }
        [Fact]
        public void ListRemove()
        {
            List<int> obj = new List<int>
            {
                1,3,5
            };
            obj.Remove(3);
            Assert.False(obj.Contains(3));
        }
        [Fact]
        public void ListCopyTo()
        {
            int[] test = new int[]
            {
                1,3,5,7,9,11,17
            };
            var toCopy = new List<int>
            {
                10,11,12,13
            };
            toCopy.CopyTo(test, 2);
            Assert.Equal(new int[] { 1, 3, 10, 11, 12, 13,17}, test);
        }
    }
}
