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
            Assert.AreEqual(0, CalculateCube(1));
        }
        public int CalculateCube(int number)
        {
            return 0;
        }
    }
}
