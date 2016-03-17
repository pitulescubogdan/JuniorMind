﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalTriangle
{
    [TestClass]
    public class PascalTriangle
    {
        [TestMethod]
        public void Pascal()
        {
            Assert.AreEqual(1, GetPascal(1, 1));
        }
        
        public int GetPascal(int row, int column)
        {
            if (row == 0 || column == 0)
            {
                return 1;
            }
            return 1;
        }
    }
}
