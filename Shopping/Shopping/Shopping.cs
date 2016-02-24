using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shopping
{
    [TestClass]
    public class Shopping
    {
        public struct ShoppingList
        {
            public string nameOfProduct;
            public double amount;
            public ShoppingList(string nameOfProduct, double amount)
            {
                this.nameOfProduct = nameOfProduct;
                this.amount = amount;
            }

        }
        [TestMethod]
        public void ShoppingTest()
        {
            var shopping = new ShoppingList[] { new ShoppingList("bread",3.4),new ShoppingList("milk",3.7),new ShoppingList("oil",7) };
            Assert.AreEqual(14.1, CalculateTotalPrice(shopping));
        }
        public double CalculateTotalPrice(ShoppingList[] shoppingList)
        {
            double result = 0;
            for (int i = 0; i < shoppingList.Length; i++)
            {
                result += shoppingList[i].amount;
            }
            return result;
        }
    }
}
