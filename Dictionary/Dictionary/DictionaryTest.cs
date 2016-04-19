using Xunit;

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
            obj.Add(5, "Mihai");
            obj.Add(1, "1234");
            obj.Add(5, "Marius");
            Assert.Equal(5, obj.Count);
        }
        [Fact]
        public void DictionaryTestContains()
        {
            var obj = new Dictionary<int, string>();
            obj.Add(5, "abc");
            Assert.True(obj.ContainsKey(5));
        }
    }
}
