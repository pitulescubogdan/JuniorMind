using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shopping
{
    [TestClass]
    public class Shopping
    {
        public struct Product
        {
            public string nameOfProduct;
            public double amount;
            public Product(string nameOfProduct, double amount)
            {
                this.nameOfProduct = nameOfProduct;
                this.amount = amount;
            }

        }
        [TestMethod]
        public void GreatestPrice()
        {
            var shopping = new Product[] { new Product("bread", 3.4), new Product("milk", 3.7), new Product("oil", 7) };
            Assert.AreEqual(14.1, CalculateTotalPrice(shopping));
        }
        [TestMethod]
        public void CheapestObject()
        {
            var shopping = new Product[] { new Product("milk", 3.7), new Product("bread", 3.4), new Product("oil", 7) };
            Assert.AreEqual(new Product("bread", 3.4), CalculateTheMinimumObject(shopping));

        }
        [TestMethod]
        public void HighestObject()
        {
            var shopping = new Product[] { new Product("milk", 3.7), new Product("bread", 3.4), new Product("oil", 7) };
            Assert.AreEqual(2, GetMaxObjectPosition(shopping));

        }
        [TestMethod]
        public void AveragePrice()
        {
            var shopping = new Product[] { new Product("milk", 3.7), new Product("bread", 3.4), new Product("oil", 7) };
            Assert.AreEqual(4.7, CalculateAverageShopping(shopping));
        }
        [TestMethod]
        public void EliminateTheHighest()
        {
            var shopping = new Product[] { new Product("milk", 3.7), new Product("bread", 3.4), new Product("oil", 7) };

            Assert.AreEqual(2, CountObjects(RemoveTheMostExpensive(shopping)));
        }
        [TestMethod]
        public void EliminateTheHighestBetweenTwoObjects()
        {
            var shopping = new Product[] { new Product("oil", 7), new Product("bread", 3.4) };
            CollectionAssert.AreEqual(new Product[] { new Product("bread", 3.4) },
                RemoveTheMostExpensive(shopping));
        }
        [TestMethod]
        public void EliminateTheHighestBetweenThreeObjects()
        {
            var shopping = new Product[] { new Product("bread", 3.4), new Product("oil", 7), new Product("chocolate", 5) };
            CollectionAssert.AreEqual(new Product[] { new Product("bread", 3.4), new Product("chocolate", 5) },
                RemoveTheMostExpensive(shopping));
        }
        [TestMethod]
        public void EliminateTheHighestBetweenMoreProducts()
        {
            var shopping = new Product[] { new Product("bread", 3.4), new Product("oil", 7), new Product("chocolate", 5), new Product("seeds", 4) };
            CollectionAssert.AreEqual(new Product[] { new Product("bread", 3.4), new Product("seeds", 4), new Product("chocolate", 5) },
                RemoveTheMostExpensive(shopping));
        }
        [TestMethod]
        public void AddObject()
        {
            var actualShopping = new Product[] { new Product("chocolate", 5), new Product("honey", 15) };
            var newObject = new Product("Oreo", 4);
            Assert.AreEqual(3, CountObjects(AddObject(actualShopping, newObject)));
        }
        [TestMethod]
        public void AddAnObjectToChart()
        {
            var actualShopping = new Product[] { new Product("chocolate", 5), new Product("honey", 15) };
            var newObject = new Product("Oreo", 4);
            var newListOfObjects = new Product[] { new Product("chocolate", 5), new Product("honey", 15), new Product("Oreo", 4) };
            CollectionAssert.AreEqual(newListOfObjects, AddObject(actualShopping, newObject));
        }

        public double CalculateTotalPrice(Product[] shoppingList)
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
        public Product CalculateTheMinimumObject(Product[] shoppingObject)
        {
            Product firstObject = shoppingObject[0];
            Product result = shoppingObject[0];
            for (int i = 0; i < shoppingObject.Length; i++)
            {
                result = (firstObject.amount < shoppingObject[i].amount) ? result : shoppingObject[i];

            }
            return result;
        }
        public double CalculateAverageShopping(Product[] shoppingObject)
        {
            int counter = shoppingObject.Length;

            return CalculateTotalPrice(shoppingObject) / counter;
        }
        public Product[] RemoveTheMostExpensive(Product[] shoppingObject)
        {
            shoppingObject[GetMaxObjectPosition(shoppingObject)] = shoppingObject[shoppingObject.Length - 1];

            Array.Resize(ref shoppingObject, shoppingObject.Length - 1);

            return shoppingObject;
        }
        public int GetMaxObjectPosition(Product[] shoppingObjects)
        {
            Product firstObject = shoppingObjects[0];
            int result = 0;
            for (int i = 0; i < shoppingObjects.Length; i++)
            {
                if (firstObject.amount < shoppingObjects[i].amount)
                {
                    result = i;
                    firstObject = shoppingObjects[i];
                }

            }
            return result;
        }

        public int CountObjects(Product[] shoppingObjects)
        {
            return shoppingObjects.Length;
        }
        public Product[] AddObject(Product[] shoppingObjects, Product newObject)
        {
            Array.Resize(ref shoppingObjects, shoppingObjects.Length + 1);
            shoppingObjects[shoppingObjects.Length - 1] = newObject;
            return shoppingObjects;
        }

    }
}