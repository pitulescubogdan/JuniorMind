﻿using System;
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
        [Fact]
        public void TestRemove()
        {
            var list = new LinkedLists<int> { 1, 2, 3, 4, 5 };
            Assert.Equal(5, list.Count);
            list.Remove(2);
            Assert.Equal(4, list.Count);
            list.Remove(0);
            Assert.Equal(3, list.Count);
            list.Clear();
            Assert.Equal(0, list.Count);
        }
    }
}