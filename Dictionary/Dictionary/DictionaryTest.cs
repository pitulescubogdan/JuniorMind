using Xunit;
using System.Collections.Generic;

namespace Dictionary
{
    public class DictionaryTest
    {
        [Fact]
        public void DictionaryTestAdd()
        {
            var obj = new Dictionary<int, string>();
            obj.Add(5, "Bogdan");
            obj.Add(3, "bb");
            obj.Add(3, "Three");
            obj.Remove(new KeyValuePair<int, string>(3, "Three"));
            obj.Add(3, "Three");
            obj.Add(5, "Mihai");
            obj.Add(1, "1234");
            obj.Add(5, "Marius");
            Assert.Equal(6, obj.Count);
        }
        [Fact]
        public void DictionaryTestContainsKey()
        {
            var obj = new Dictionary<int, string> {
                {1,"One" },
                {2,"Two" }
            };
            obj.Add(5, "abc");
            Assert.True(obj.ContainsKey(5));
            Assert.True(obj.Contains(new KeyValuePair<int, string>(2, "Two")));
        }
        [Fact]
        public void DictionaryTestContains()
        {
            var obj = new Dictionary<int, string>();
            obj.Add(3, "ThirdThree");
            obj.Add(3, "Three");
            obj.Add(5, "Five ");
            obj.Add(5, "Three");
            obj.Add(3, "AnotherThree");
            obj.Add(3, "SecondThree");
            Assert.True(obj.Contains(new KeyValuePair<int, string>(3, "Three")));
        }
        [Fact]
        public void DictionaryTestRemove()
        {
            var obj = new Dictionary<int, string>();
            obj.Add(1, "One");
            obj.Add(1, "2One");
            obj.Add(2, "Two");
            obj.Remove(1);
            Assert.False(obj.ContainsKey(1));
            Assert.True(obj.Contains(new KeyValuePair<int, string>(2, "Two")));
        }
        [Fact]
        public void DictionaryTestTryGetvalue()
        {
            var obj = new Dictionary<int, string>
            {
                {1,"Cat" },
                {2,"Dog" },
                {3,"Mouse" }
            };
            string test = string.Empty;
            obj.TryGetValue(2, out test);
            Assert.Equal("Dog",test);
        }
    }
}
