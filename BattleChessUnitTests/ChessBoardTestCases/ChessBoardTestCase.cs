using System;
using BattleChess.Core;
using BattleChess.Infrastructure;
using BattleChess.Interfaces;
using BattleChessUnitTests.MockedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;

namespace BattleChessUnitTests.ChessBoardTestCases
{
    [TestClass]
    public class ChessBoardTestCase : AbstractChessBoardTestCase
    {
        [ClassInitialize]
        public static void Init(TestContext context)
        {
            BaseInitialize(context);
        }

        protected override IChessBoard CreateBoard()
        {
            return new MockedChessBoard();
        }
    }
}
