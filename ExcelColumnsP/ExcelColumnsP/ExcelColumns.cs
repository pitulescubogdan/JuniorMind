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
        [TestMethod]
        public void TestForZ()
        {
            Assert.AreEqual("Z", CalculateTheExcelColumns(26));
        }
        [TestMethod]
        public void TestFor27()
        {
            Assert.AreEqual("AA", CalculateTheExcelColumns(27));
        }
        [TestMethod]
        public void TestFor52()
        {
            Assert.AreEqual("AZ", CalculateTheExcelColumns(52));

        }
        [TestMethod]
        public void TestFor40()
        {
            Assert.AreEqual("AN", CalculateTheExcelColumns(40));

        }
        [TestMethod]
        public void TestForZZ()
        {
            Assert.AreEqual("ZZ", CalculateTheExcelColumns(702));
        }

        public string CalculateTheExcelColumns(int numberColumn)
        {
            string result = String.Empty;
            while(numberColumn-- > 0)
            {      
                result =  ReturnExcelColumn((numberColumn) % 26) + result;
                numberColumn = numberColumn / 26;
            }
            return result;      
        }
        public String ReturnExcelColumn(int number)
        {
            
            return ((char)('A' + number)).ToString();
        }
    }
}
