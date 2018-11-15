using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Chess;

namespace Chess.Tests
{
     [TestClass]
    public class ChessTest 
    {
        [TestMethod]
        public void IsAttackable_PieceIsOnBoard_True()
        {
            ChessClass testChess = new ChessClass(1,1,1,1);
            Assert.AreEqual(true, testChess.IsAttackable(1,1,1,1));
        }

         [TestMethod]
        public void IsAttackable_SameRow_True()
        {
            ChessClass testChess = new ChessClass(1,5,8,5);
            Assert.AreEqual(true, testChess.IsAttackable(1,5,8,5));
        }

         [TestMethod]
        public void IsAttackable_DifferentRow_True()
        {
            ChessClass testChess = new ChessClass(2,4,2,5);
            Assert.AreEqual(true, testChess.IsAttackable(2,4,2,5));
        }

        [TestMethod]
        public void IsAttackable_Diagonal_True()
        {
            ChessClass testChess = new ChessClass(4,4,8,8);
            Assert.AreEqual(true, testChess.IsAttackable(4,4,8,8));
        }
    }
}