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
        public void TestForAnyColumnInTheFirstStage()
        {
            Assert.AreEqual("O", CalculateTheExcelColumns(15));

        }
        [TestMethod]
        public void TestForSecondInterval()
        {
            Assert.AreEqual("AH", CalculateTheExcelColumns(34));
        }
        [TestMethod]
        public void TestForThirdInterval()
        {
            Assert.AreEqual("BH", CalculateTheExcelColumns(60));

        }
        public string CalculateTheExcelColumns(int numberColumn)
        {
            int number;
            int numberOfInterval = 1;
            string output = "";
            String[] columns = {"A","B","C","D","E","F","G"
                    ,"H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

            numberOfInterval = numberColumn / 26;
            for (int i = 1; i < columns.Length; i++)
            {
                if (numberOfInterval != 0)
                {
                    number = 0;
                    if (numberColumn > (numberOfInterval * 26))
                    {
                        number = numberColumn - (numberOfInterval * 26);
                        output = columns[numberOfInterval - 1] + columns[number - 1];
                    }
                }
                else
                {
                    output = columns[numberColumn - 1];
                }
            }
            return output;          
        }
    }
}
