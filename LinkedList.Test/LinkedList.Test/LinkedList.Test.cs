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
            list.Add(0);
            Assert.Equal(4, list.Count);
        }
        [Fact]
        public void TestRemove()
        {
            var list = new LinkedLists<int> { 1, 2, 3, 4, 5 };
            Assert.Equal(5, list.Count);
            list.RemoveAt(2);
            Assert.False(list.Contains(3));
            list.RemoveAt(0);
            Assert.False(list.Contains(1));
            list.Clear();
            Assert.Equal(0, list.Count);
        }
        [Fact]
        public void TestIndexOf()
        {
            var list = new LinkedLists<string>{"a","b","c"};
            Assert.Equal(1, list.IndexOf("b"));
            Assert.Equal(-1, list.IndexOf("z"));
        }
        [Fact]
        public void TestContains()
        {
            var list = new LinkedLists<char> { 'a', 'b', 'c', 'd', 'e' };
            Assert.True(list.Contains('d'));
            Assert.False(list.Contains('z'));
        }
        [Fact]
        public void TestPrevious()
        {
            var list = new LinkedLists<int> { 2, 3, 4 };
            list.AddFirst(1);
            Assert.Equal(4, list.Count);
        }
        [Fact]
        public void TestCopyTo()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var copy = new LinkedLists<int> { 10, 9 };
            copy.CopyTo(numbers, 2);
            Assert.Equal(new int[] { 1, 2, 10, 9, 5 },numbers);
        }

    }
}
