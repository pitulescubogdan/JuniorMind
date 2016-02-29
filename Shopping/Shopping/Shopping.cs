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
            Assert.AreEqual(new ShoppingList("bread", 3.4), CalculateTheMinimumObject(shopping));

        }
        [TestMethod]
        public void HighestObject()
        {
            var shopping = new ShoppingList[] { new ShoppingList("milk", 3.7), new ShoppingList("bread", 3.4), new ShoppingList("oil", 7) };
            Assert.AreEqual(new ShoppingList("oil", 7), GetTheHighestPrice(shopping));

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
            CollectionAssert.AreEqual(new ShoppingList[] { new ShoppingList("bread", 3.4) }, 
                RemoveTheMostExpensive(shopping));
        }
        [TestMethod]
        public void AddObject()
        {
            var actualShopping = new ShoppingList[] { new ShoppingList("chocolate", 5), new ShoppingList("honey", 15) };
            var newObject = new ShoppingList("Oreo", 4);
            Assert.AreEqual(3, CountObjects(AddObject(actualShopping,newObject)));
        }
        [TestMethod]
        public void AddAnObjectToChart()
        {
            var actualShopping = new ShoppingList[] { new ShoppingList("chocolate", 5), new ShoppingList("honey", 15) };
            var newObject = new ShoppingList("Oreo", 4);
            var newListOfObjects = new ShoppingList[] { new ShoppingList("chocolate", 5), new ShoppingList("honey", 15), new ShoppingList("Oreo", 4) };
            CollectionAssert.AreEqual(newListOfObjects, AddObject(actualShopping, newObject));
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
        public ShoppingList CalculateTheMinimumObject(ShoppingList[] shoppingObject)
        {
            ShoppingList firstObject = shoppingObject[0];
            ShoppingList result = shoppingObject[0];
            for (int i = 0; i < shoppingObject.Length; i++)
            {
                result = (firstObject.amount < shoppingObject[i].amount) ? result : shoppingObject[i];

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

            Array.Sort(shoppingObjects);
            
            Array.Resize(ref shoppingObjects, shoppingObjects.Length - 1);

            return shoppingObjects;
        }

        public ShoppingList GetTheHighestPrice(ShoppingList[] shoppingObjects)
        {
            ShoppingList firstObject = shoppingObjects[0];
            ShoppingList result = shoppingObjects[0];
            for (int i = 0; i < shoppingObjects.Length; i++)
            {
                result = (firstObject.amount > shoppingObjects[i].amount) ? result : shoppingObjects[i];

            }
            return result;
        }

        public int CountObjects(ShoppingList[] shoppingObjects)
        {
            return shoppingObjects.Length;
        }
        public ShoppingList[] AddObject(ShoppingList[] shoppingObjects,ShoppingList newObject)
        {
            Array.Resize(ref shoppingObjects, shoppingObjects.Length + 1);
            shoppingObjects[shoppingObjects.Length - 1] = newObject;
            return shoppingObjects;
        }

    }
}