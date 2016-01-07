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
        public string CalculateTheExcelColumns(int numberColumn)
        {
            string output = "";
            String[] columns = {"A","B","C","D","E","F","G"
                    ,"H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
            for (int i = 1; i < columns.Length; i++)
            {                                         
                    output = columns[numberColumn - 1];                      
            }
            return output;
        }
    }
}
