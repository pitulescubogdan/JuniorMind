using System;
using System.Collections.Generic;
using Xunit;


namespace LinkedList.Test
{
    public class LinkedListTest
    {
        [Fact]
        public void LinkedListTestEmpty()
        {
            var list = new LinkedLists<int>();
            Assert.True(list.Empty);
            Assert.Equal(0, list.Count);
        }
    }
}
