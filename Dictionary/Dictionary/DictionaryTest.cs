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
            Assert.Equal(1, obj.Count);
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
