using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumnsP
{
    [TestClass]
    public class ExcelColumns
    {
        [TestMethod]
        public void TestForFirstColumn()
        {
            Assert.AreEqual("A", CalculateTheExcelColumns(1));
        }
       
        public string CalculateTheExcelColumns(int numberColumn)
        {
            string result = String.Empty;

            result = ReturnExcelColumn(numberColumn);
            
            return result;          
        }
        public String ReturnExcelColumn(int number)
        {

            return ((char)('A' + number - 1)).ToString();
        }
    }
}
