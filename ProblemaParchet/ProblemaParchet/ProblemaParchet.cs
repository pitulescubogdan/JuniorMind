using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemaParchet
{
    [TestClass]
    public class ProblemaParchet
    {
        [TestMethod]
        public void TestMethod1()
        {
            double result = calculDimensionOfParquetUsed(3, 3, 1, 0.5);
            Assert.AreEqual(12, result);
        }
        double calculDimensionOfParquetUsed(int heightRoom,int widthRoom, double heightOfParquet,double widthOfParquet
            )
        {
            double roomDimension = heightRoom * widthRoom;
            double parquetDimension = heightOfParquet * widthOfParquet;
            double nrOfParquetPieces = roomDimension / parquetDimension;
            double lossOfParquet = 0.15 * Math.Ceiling(nrOfParquetPieces);//15% din placile de parchet
            double ParquetNeededDimension = Math.Ceiling(nrOfParquetPieces) * parquetDimension + (lossOfParquet);

            return Math.Ceiling(ParquetNeededDimension);
        }
    }
}
