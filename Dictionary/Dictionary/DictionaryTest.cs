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
            obj.Add(22, "mam");
            obj.Add(3, "Three");
            obj.Add(3, "sall");
            obj.Remove(3);
            obj.Add(3, "Threes");
            obj.Add(5, "Mihai");
            obj.Add(1, "1234");
            obj.Add(5, "Marius");
            Assert.Equal(6, obj.Count);
        }
        [Fact]
        public void DictionaryTestContainsKey()
        {
            var obj = new Dictionary<int, string>(){
                {1,"One" },
                {2,"Two" },
                {13,"test" }
            };
            obj.Add(5, "abc");
            Assert.True(obj.ContainsKey(13));
            Assert.False(obj.ContainsKey(22));
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
        public void DictionaryTestTryGetValue()
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
        [Fact]
        public void DictionaryTestCopyTo()
        {
            var obj = new Dictionary<int, string>
            {
                {1,"ONE"},
                {2,"TWO"}
            };
            var someEntry = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int,string>(10,"TEN"),
                new KeyValuePair<int,string>(11,"ELEVEN")
            };

            obj.CopyTo(someEntry, 0);
            Assert.Equal(new KeyValuePair<int, string>(1, "ONE"), someEntry[0]);
            Assert.Equal(new KeyValuePair<int, string>(2, "TWO"), someEntry[1]);
        }
    }
}
