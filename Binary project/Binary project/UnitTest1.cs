using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binary_project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DecimalToByte()
        {
            Assert.AreEqual(0, ToByte(0));
        }
        public byte ToByte(int number)
        {

            return 0;
        }
    }
}
