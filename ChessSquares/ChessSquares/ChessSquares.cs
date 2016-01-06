using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessSquares
{
    [TestClass]
    public class ChessSquares
    {
        [TestMethod]
        public void ChessSquareForOne()
        {
            Assert.AreEqual(1, CalculateChessSquares(1));
        }
        [TestMethod]
        public void ChessSquaresForEight()
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
