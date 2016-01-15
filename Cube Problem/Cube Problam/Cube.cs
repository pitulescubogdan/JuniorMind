using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube_Problam
{
    [TestClass]
    public class Cube   
    {
        [TestMethod]
        public void CheckCubeForOneK()
        {
            Assert.AreEqual(192, CalculateCube(1));
        }
        [TestMethod]
        public void CheckCubeForTwoK()
        {
            Assert.AreEqual(442, CalculateCube(2));          
        }
        [TestMethod]
        public void CheckCubeForAnyK()
        {
            Assert.AreEqual(4942, CalculateCube(20));          
            
        }
        public long CalculateCube(int numberOfCube)
        {
            long number = 1;
            int aux = 0;
            long cubicNumber = number * number * number;

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
