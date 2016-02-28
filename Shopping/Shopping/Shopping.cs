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
        public void GreatestPrice()
        {
            var shopping = new ShoppingList[] { new ShoppingList("bread", 3.4), new ShoppingList("milk", 3.7), new ShoppingList("oil", 7) };
            Assert.AreEqual(14.1, CalculateTotalPrice(shopping));
        }
        [TestMethod]
        public void CheapestObject()
        {
            var shopping = new ShoppingList[] { new ShoppingList("milk", 3.7), new ShoppingList("bread", 3.4), new ShoppingList("oil", 7) };
            Assert.AreEqual(3.4, CalculateTheMinimumObject(shopping));

        }
        [TestMethod]
        public void AveragePrice()
        {
            var shopping = new ShoppingList[] { new ShoppingList("milk", 3.7), new ShoppingList("bread", 3.4), new ShoppingList("oil", 7) };
            Assert.AreEqual(4.7, CalculateAverageShopping(shopping));
        }
        [TestMethod]
        public void EliminateTheHighest()
        {
            var shopping = new ShoppingList[] { new ShoppingList("milk", 3.7), new ShoppingList("bread", 3.4), new ShoppingList("oil", 7) };

            Assert.AreEqual(2,CountObjects(RemoveTheMostExpensive(shopping)));
        }
        [TestMethod]
        public void EliminateTheHighestBetweenTwoObjects()
        {
            var shopping = new ShoppingList[] { new ShoppingList("oil", 7), new ShoppingList("bread", 3.4),  };
            CollectionAssert.AreEqual(new ShoppingList[] { new ShoppingList("bread", 3.4) }, RemoveTheMostExpensive(shopping));

        }

        public double CalculateTotalPrice(ShoppingList[] shoppingList)
        {
            double result = 0;
            int counter = 0;
            for (int i = 0; i < shoppingList.Length; i++)
            {
                result += shoppingList[i].amount;
                counter++;
            }
            return result;
        }
        public double CalculateTheMinimumObject(ShoppingList[] shoppingObject)
        {
            ShoppingList firstObject = shoppingObject[0];
            double result = 0;
            for (int i = 0; i < shoppingObject.Length; i++)
            {
                result = (firstObject.amount < shoppingObject[i].amount) ? result : shoppingObject[i].amount;

            }
            return result;
        }
        public double CalculateAverageShopping(ShoppingList[] shoppingObject)
        {
            int counter = shoppingObject.Length;

            return CalculateTotalPrice(shoppingObject) / counter;
        }
        public ShoppingList[] RemoveTheMostExpensive(ShoppingList[] shoppingObjects)
        {
            for(int i = 0; i < shoppingObjects.Length; i++)
               for(int j = 0; j < shoppingObjects.Length - 1; j++)
                {
                    if(shoppingObjects[j].amount > shoppingObjects[j+1].amount)
                    {
                        ShoppingList higherValue = shoppingObjects[j];
                        shoppingObjects[j] = shoppingObjects[j + 1];
                        shoppingObjects[j + 1] = higherValue;
                    }
                }
            Array.Resize(ref shoppingObjects, shoppingObjects.Length - 1);
            return shoppingObjects;
        }
        public int CountObjects(ShoppingList[] shoppingObjects)
        {
            return shoppingObjects.Length;
        }

    }
}