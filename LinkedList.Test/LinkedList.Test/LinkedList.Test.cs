using System;
using System.Collections.Generic;
using Xunit;


namespace LinkedList.Test
{
    public class LinkedListTest
    {
        [Fact]
        public void TestEmpty()
        {
            var list = new LinkedLists<int>();
            Assert.True(list.Empty);
            Assert.Equal(0, list.Count);
        }
        [Fact]
        public void TestAdd()
        {
            var list = new LinkedLists<int> { 1, 2, 3 };
            Assert.Equal(3, list.Count);
            list.Add(0, 0);
            Assert.Equal(4, list.Count);
        }
    }
}
