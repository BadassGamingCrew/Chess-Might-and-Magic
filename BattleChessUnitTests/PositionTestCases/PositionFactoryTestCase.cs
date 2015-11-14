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
    public class PositionFactoryTestCase : AbstractPositionFactoryTestCase
    {
        [ClassInitialize]
        public static void Init(TestContext context)
        {
            BaseInit(context);
        }

        protected override IPositionFactory GetFactory()
        {
            return PositionFactory.Instance;
        }
    }
}
