using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Interfaces;
using BattleChess.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;

namespace BattleChessUnitTests.PositionTestCases
{
    public abstract class AbstractPositionTestCase
    {
        private readonly char firstPositionColumn = 'A';
        private readonly char secondPositionColumn = 'B';
        private readonly int firstPositionRow = 1;
        private readonly int secondPositionRow = 2;
        private IPosition firstPosition;
        private IPosition secondPosition;

        protected abstract IPosition GetPosition(char column, int row);

        [ClassInitialize]
        public static void BaseInit(TestContext context)
        {
        }

        [TestInitialize]
        public void SetUp()
        {
            this.firstPosition = GetPosition(this.firstPositionColumn, this.firstPositionRow);
            this.secondPosition = GetPosition(this.secondPositionColumn, this.secondPositionRow);
        }

        [TestCleanup]
        public void TearDown()
        {
            this.firstPosition = null;
            this.secondPosition = null;
        }

        [TestMethod]
        public void TestColumnPropertyReturnsCorrectValue()
        {
            Assert.IsNotNull(this.firstPosition.Column);
            Assert.AreEqual(this.firstPositionColumn, this.firstPosition.Column);
            Assert.AreNotEqual(this.secondPositionColumn, this.firstPosition.Column);
        }

        [TestMethod]
        public void TestRowPropertyReturnsCorrectValue()
        {
            Assert.IsNotNull(this.firstPosition.Row);
            Assert.AreEqual(this.firstPositionRow, this.firstPosition.Row);
            Assert.AreNotEqual(this.secondPositionRow, this.firstPosition.Row);
        }

        [TestMethod]
        public void TestEqualsReturnsTrueWhenPositionsAreEqual()
        {
            IPosition result = this.GetPosition(this.firstPositionColumn, this.firstPositionRow);
            Assert.AreEqual(this.firstPosition, result);
        }

        [TestMethod]
        public void TestEqualsReturnsFalseWhenPositionsAreNotEqual()
        {
            Assert.AreNotEqual(this.firstPosition, this.secondPosition);
        }

        [TestMethod]
        public void TestEqualsReturnsFalseWhenPositionsHaveDifferentColumns()
        {
            IPosition result = this.GetPosition(this.secondPositionColumn, this.firstPositionRow);
            Assert.AreNotEqual(this.firstPosition, result);
        }

        [TestMethod]
        public void TestEqualsReturnsFalseWhenPositionsHaveDifferentRows()
        {
            IPosition result = this.GetPosition(this.firstPositionColumn, this.secondPositionRow);
            Assert.AreNotEqual(this.firstPosition, result);
        }

        [TestMethod]
        public void TestEqualsReturnsTrueWhenPositionsAreSame()
        {
            Assert.AreSame(this.firstPosition, this.firstPosition);
        }

        [TestMethod]
        public void TestEqualsReturnsFalseWhenPositionsAreNotSame()
        {
            Rectangle result = new Rectangle();
            Assert.AreNotSame(this.firstPosition, result);
        }
    }
}
