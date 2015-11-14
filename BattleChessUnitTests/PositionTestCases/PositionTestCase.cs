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
    [TestClass]
    public class PositionTestCase : AbstractPositionTestCase
    {
        private static readonly IPositionFactory Factory = PositionFactory.Instance;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            BaseInit(context);
        }

        protected override IPosition GetPosition(char column, int row)
        {
            return Factory.Create(column, row);
        }
    }
}
