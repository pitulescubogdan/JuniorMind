using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumnsP
{
    [TestClass]
    public class ExcelColumns
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("A", CalculateTheExcelColumns(1));
        }
        public string CalculateTheExcelColumns(int numberColumn)
        {

            return "A";
        }
    }
}
