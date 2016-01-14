using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube_Problam
{
    [TestClass]
    public class Cube
    {
        [TestMethod]
        public void CheckCube()
        {
            Assert.AreEqual(192, CalculateCube(1));
        }
        public int CalculateCube(int numberOfCube)
        {
            int number = 1;
            int aux = 0;
            int cubicNumber = number * number * number;

            while (cubicNumber % 1000 != 888 || aux != numberOfCube)
            {
                number++;
                cubicNumber = number * number * number;
                

                if (cubicNumber % 1000 == 888) aux++;
            }
            return number;
        }
        
    }
}
