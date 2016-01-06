using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessSquares
{
    [TestClass]
    public class ChessSquares
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, CalculateChessSquares(2));
        }
        public int CalculateChessSquares(int chessLength)
        {
            int result=0;

            while(!(chessLength==0))
            {
                result += chessLength * chessLength;
                chessLength--;
            }
            

            return result;
        }
    }
}
