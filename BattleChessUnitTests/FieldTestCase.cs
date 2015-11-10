﻿// <auto-generated />

using System;

namespace BattleChessUnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BattleChess.Interfaces;
    using BattleChess.Infrastructure;
    using BattleChess.Utilities;
    using BattleChess.Core;

    /// <summary>
    /// Unit Tests for IField objects
    /// </summary>
    [TestClass]
    public class FieldTestCase
    {
        private const ColorType Black = ColorType.Black;
        private const ColorType White = ColorType.White;
        private IChessPiece blackPawn;
        private IChessPiece whitePawn;
        private IChessBoard board;
        private IPosition position;
        private IField field;
        private char column;
        private int row;
        private string failMessage;

        [TestInitialize]
        public void SetUp()
        {
            this.column = 'A';
            this.row = 1;
            this.blackPawn = new PawnChessPiece(Black);
            this.whitePawn = new PawnChessPiece(White);
            this.board = new ChessBoard(new GameEngine());
            this.position = new Position(this.column, this.row);
        }

        [TestCleanup]
        public void TearDown()
        {
            this.column = '\0';
            this.row = 0;
            this.blackPawn = null;
            this.whitePawn = null;
            this.board = null;
            this.position = null;
            this.field = null;
            this.failMessage = null;
        }

        [TestMethod]
        public void TestCreateNewBlackFieldDoesNotThrowException()
        {
            try
            {
                this.field = this.CreateBlackField();
            }
            catch (Exception e)
            {
                this.FailWithException(e);
            }
        }

        [TestMethod]
        public void TestCreateNewWhiteFieldDoesNotThrowException()
        {
            try
            {
                this.field = this.CreateWhiteField();
            }
            catch (Exception e)
            {
                this.FailWithException(e);
            }
        }

        [TestMethod]
        public void TestGetChessBoardReturnsSameObjectForNewBlackField()
        {
            this.field = this.CreateBlackField();
            Assert.AreSame(this.board, this.field.ChessBoard);
        }

        [TestMethod]
        public void TestGetChessBoardReturnsSameObjectForNewWhiteField()
        {
            this.field = this.CreateWhiteField();
            Assert.AreSame(this.board, this.field.ChessBoard);
        }

        [TestMethod]
        public void TestBlackFieldGetChessBoardIsNotSameAsOtherChessBoard()
        {
            this.field = this.CreateBlackField();
            this.board = new ChessBoard(new GameEngine());

            Assert.IsNotNull(this.field.ChessBoard);
            Assert.AreNotSame(this.board, this.field.ChessBoard);
        }

        [TestMethod]
        public void TestWhiteFieldGetChessBoardIsNotSameAsOtherChessBoard()
        {
            this.field = this.CreateWhiteField();
            this.board = new ChessBoard(new GameEngine());

            Assert.IsNotNull(this.field.ChessBoard);
            Assert.AreNotSame(this.board, this.field.ChessBoard);
        }

        [TestMethod]
        public void TestGetPositionReturnsSameObjectForNewBlackField()
        {
            this.field = this.CreateBlackField();
            Assert.AreSame(this.position, this.field.Position);
        }

        [TestMethod]
        public void TestGetPositionReturnsSameObjectForNewWhiteField()
        {
            this.field = this.CreateWhiteField();
            Assert.AreSame(this.position, this.field.Position);
        }

        [TestMethod]
        public void TestBlackFieldGetPositionIsNotSameAsOtherPositionWithDifferentValues()
        {
            this.field = this.CreateBlackField();
            this.position = new Position('B', 2);

            Assert.IsNotNull(this.field.Position);
            Assert.AreNotSame(this.position, this.field.Position);
        }

        [TestMethod]
        public void TestWhiteFieldGetPositionIsNotSameAsOtherPositionWithDifferentValues()
        {
            this.field = this.CreateWhiteField();
            this.position = new Position('B', 2);

            Assert.IsNotNull(this.field.Position);
            Assert.AreNotSame(this.position, this.field.Position);
        }

        [TestMethod]
        public void TestBlackFieldPositionIsEqualToOriginalPosition()
        {
            this.field = this.CreateBlackField();
            Assert.AreEqual(this.position, this.field.Position);
        }

        [TestMethod]
        public void TestWhiteFieldPositionIsEqualToOriginalPosition()
        {
            this.field = this.CreateWhiteField();
            Assert.AreEqual(this.position, this.field.Position);
        }

        [TestMethod]
        public void TestBlackFieldPositionIsNotEqualToOtherPositionWithDifferentValues()
        {
            this.field = this.CreateBlackField();
            this.position = new Position('B', 2);
            Assert.AreNotEqual(this.position, this.field.Position);
        }

        [TestMethod]
        public void TestWhiteFieldPositionIsNotEqualToOtherPositionWithDifferentValues()
        {
            this.field = this.CreateWhiteField();
            this.position = new Position('B', 2);
            Assert.AreNotEqual(this.position, this.field.Position);
        }

        [TestMethod]
        public void TestBlackFieldPositionIsEqualToOtherPositionWithSameValues()
        {
            this.field = this.CreateBlackField();
            this.position = new Position('A', 1);
            Assert.AreEqual(this.position, this.field.Position);
        }

        [TestMethod]
        public void TestWhiteFieldPositionIsEqualToOtherPositionWithSameValues()
        {
            this.field = this.CreateWhiteField();
            this.position = new Position('A', 1);
            Assert.AreEqual(this.position, this.field.Position);
        }

        private IField CreateBlackField()
        {
            return new BlackField(this.position, this.board);
        }

        private IField CreateWhiteField()
        {
            return new WhiteField(this.position, this.board);
        }

        private void FailWithException(Exception e)
        {
            this.failMessage = string.Format("Unexpected exception of type {0}\nException Message: {1}\n",
                    e.GetType(), e.Message);
            Assert.Fail(failMessage);
        }
    }
}