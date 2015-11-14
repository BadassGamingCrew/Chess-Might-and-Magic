using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Interfaces;
using BattleChess.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleChessUnitTests.PositionTestCases
{
    public abstract class AbstractPositionFactoryTestCase
    {
        [ClassInitialize]
        public static void BaseInit(TestContext context)
        {
        }

        private const string InvalidColumnErrorMessage = ErrorMessages.InvalidColumn;
        private const string InvalidRowErrorMessage = ErrorMessages.InvalidRow;
        private IPositionFactory factory;
        private IPosition result;
        private char validColumn;
        private char invalidColumn;
        private int validRow;
        private int invalidRow;

        protected abstract IPositionFactory GetFactory();

        [TestInitialize]
        public void SetUp()
        {
            this.factory = this.GetFactory();
            this.validColumn = 'A';
            this.invalidColumn = 'Z';
            this.validRow = 1;
            this.invalidRow = -1;
        }

        [TestMethod]
        public void TestCreatePositionWithValidParametersDoesNotThrowException()
        {
            try
            {
                result = this.factory.Create(this.validColumn, this.validRow);
            }
            catch (Exception e)
            {
                this.FailWithException(e);
            }
        }

        [TestMethod]
        public void TestCreatePositionWithValidParametersDoesNotReturnNull()
        {
            result = this.factory.Create(this.validColumn, this.validRow);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), InvalidColumnErrorMessage)]
        public void TestCreatePositionWithInvalidColumnAndValidRowThrowsColumnException()
        {
            result = this.factory.Create(this.invalidColumn, this.validRow);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException), InvalidRowErrorMessage)]
        public void TestCreatePositionWithInvalidRowAndValidColumnThrowsRowException()
        {
            result = this.factory.Create(this.validColumn, this.invalidRow);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException), InvalidColumnErrorMessage)]
        public void TestCreatePositionWithInvalidColumnAndInvalidRowThrowsColumnException()
        {
            result = this.factory.Create(this.invalidColumn, this.invalidRow);
        }

        private void FailWithException(Exception e)
        {
            string errorMessage = Utils.BuildErrorMessage(e);
            Assert.Fail(errorMessage);
        }
    }
}
