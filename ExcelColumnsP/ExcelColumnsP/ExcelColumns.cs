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
            string output = "";
            String[] columns = {"A","B","C","D","E","F","G"
                    ,"H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
            for (int i = 1; i < columns.Length; i++)
            {
                number = 0;
                if (numberColumn > 52)
                {
                    number = numberColumn - 52;
                    output = "B" + columns[number - 1];
                }
                else if(numberColumn > 26 )
                {
                    number = numberColumn - 26;
                    output = "A" + columns[number - 1];

                }else
                {
                    output = columns[numberColumn - 1];
                }
            }
            return output;          
        }
    }
}
