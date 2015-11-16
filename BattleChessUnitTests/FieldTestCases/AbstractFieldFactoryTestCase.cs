using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Infrastructure;
using BattleChess.Interfaces;
using BattleChess.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleChessUnitTests.FieldTestCases
{
    [TestClass]
    public abstract class AbstractFieldFactoryTestCase
    {
        private readonly IChessBoard chessBoard = new ChessBoard();
        private readonly ColorType white = ColorType.White;
        private readonly ColorType black = ColorType.Black;
        private readonly ColorType invalid = ((ColorType) (-1));
        private readonly IPosition position = PositionFactory.Instance.Create('A', 1);
        private IFieldFactory factory;
        private IField result;

        protected abstract IFieldFactory GetFactory();

        [ClassInitialize]
        public static void BaseInit(TestContext context)
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            this.factory = this.GetFactory();
        }

        [TestCleanup]
        public void TearDown()
        {
            this.factory = null;
        }

        [TestMethod]
        public void TestCreateDoesNotReturnThrowExceptionWithWhiteColor()
        {
            try
            {
                result = factory.Create(this.position, this.white, this.chessBoard);
            }
            catch (ArgumentOutOfRangeException e)
            {
                this.FailWithException(e);
            }
        }

        [TestMethod]
        public void TestCreateDoesNotReturnThrowExceptionWithBlackColor()
        {
            try
            {
                result = factory.Create(this.position, this.black, this.chessBoard);
            }
            catch (ArgumentOutOfRangeException e)
            {
                this.FailWithException(e);
            }
        }

        [TestMethod]
        public void TestCreateDoesNotReturnNullWithWhiteColor()
        {
            result = this.factory.Create(this.position, this.white, this.chessBoard);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestCreateDoesNotReturnNullWithBlackColor()
        {
            result = this.factory.Create(this.position, this.black, this.chessBoard);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), ErrorMessages.InvalidColor)]
        public void TestCreateThrowsExceptionWithInvalidColor()
        {
            result = this.factory.Create(this.position, this.invalid, this.chessBoard);
        }

        private void FailWithException(Exception e)
        {
            string errorMessage = Utils.BuildErrorMessage(e);
            Assert.Fail(errorMessage);
        }
    }
}
