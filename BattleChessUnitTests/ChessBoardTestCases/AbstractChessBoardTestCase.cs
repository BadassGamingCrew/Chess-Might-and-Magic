using System;
using System.Collections.Generic;
using BattleChess.Infrastructure;
using BattleChess.Interfaces;
using BattleChess.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleChessUnitTests.ChessBoardTestCases
{
    [TestClass]
    public abstract class AbstractChessBoardTestCase
    {
        private IChessBoard chessBoard;
        private IPosition position;

        protected abstract IChessBoard CreateBoard();

        [ClassInitialize]
        protected static void BaseInitialize(TestContext context)
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            this.chessBoard = this.CreateBoard();
            this.position = new Position('A', 1);
        }

        [TestCleanup]
        public void TearDown()
        {
            this.chessBoard = null;
        }

        [TestMethod]
        public void TestCreateNewChessBoardDoesNotReturnNull()
        {
            Assert.IsNotNull(this.chessBoard);
        }

        [TestMethod]
        public void TestIsdrawableReturnsTrue()
        {
            Assert.IsTrue(this.chessBoard.IsDrawable);
        }

        [TestMethod]
        public void TestDrawableAttributeSetReturnsFalse()
        {
            Assert.IsFalse(this.chessBoard.DrawableAttributeSet);
        }

        [TestMethod]
        public void TestGetFieldAtDoesNotReturnNull()
        {
            IField result = this.chessBoard.GetFieldAt(this.position);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestGetFieldAtReturnsCorrectField()
        {

            for (int c = 65; c <= 72; c++)
            {
                if (IsOdd(c))
                {
                    TestRowWithFirstFieldBlack(c);
                }
                else
                {
                    TestRowWithFirstFieldWhite(c);
                }
            }
        }

        [TestMethod]
        public void TestGetAllFieldsDoesNotReturnNull()
        {
            ICollection<IField> result = this.chessBoard.GetAllFields();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestGettAlFieldsReturnsCorrectSize()
        {
            
        }

        [TestMethod]
        public void TestGetAllFieldsReturnsCorrectFields()
        {
            
        }

        private void TestRowWithFirstFieldBlack(int c)
        {
            char column = (char) c;
            for (int row = 1; row <= 8; row++)
            {
                IPosition position = new Position(column, row);
                IField expected = new BlackField(position, this.chessBoard);
                IField result = this.chessBoard.GetFieldAt(position);

                Assert.AreEqual(expected, result);
            }
        }

        private void TestRowWithFirstFieldWhite(int c)
        {
            char column = (char)c;
            for (int row = 1; row <= 8; row++)
            {
                IPosition position = new Position(column, row);
                IField expected = new WhiteField(position, this.chessBoard);
                IField result = this.chessBoard.GetFieldAt(position);

                Assert.AreEqual(expected, result);
            }
        }

        private bool IsOdd(int num)
        {
            return num%2 != 0;
        }
    }
}
