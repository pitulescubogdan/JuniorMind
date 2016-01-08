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
        public void TestFor78()
        {
            Assert.AreEqual("ET", CalculateTheExcelColumns(150));
        }

        public string CalculateTheExcelColumns(int numberColumn)
        {
            string result = String.Empty;
            int numberOfInterval = numberColumn / 26;
            if(numberColumn > 26 && (numberColumn % 26) != 0)
            {
                int number = numberColumn % 26;
                return result = ReturnExcelColumn((numberColumn-1) / 26) + ReturnExcelColumn(number);
                
            }else if (numberColumn > 26 && numberColumn % 26 == 0)
            {
                int numberIfEqual = (numberColumn - 1) % 26;
                return result = ReturnExcelColumn((numberColumn - 1) / 26) + ReturnExcelColumn(numberIfEqual + 1);

            }

            return result = ReturnExcelColumn(numberColumn);         
        }
        public String ReturnExcelColumn(int number)
        {

            return ((char)('A' + number - 1)).ToString();
        }
    }
}
