using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shopping
{
    [TestClass]
    public class Shopping
    {
        struct List
        {
            int milk;
            int bread;
            int oil;
            public List(int milk,int bread, int oil)
            {
                this.milk = milk;
                this.bread = bread;
                this.oil = oil;
            }

        }
        [TestMethod]
        public void ShoppingTest()
        {
            Assert.AreEqual(0, CalculateTotalPrice());
        }
        public int CalculateTotalPrice()
        {
            return 0;
        }
    }
}
