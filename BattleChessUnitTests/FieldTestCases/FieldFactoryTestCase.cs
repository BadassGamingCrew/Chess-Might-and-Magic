using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Interfaces;
using BattleChess.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleChessUnitTests.FieldTestCases
{
    [TestClass]
    public class FieldFactoryTestCase : AbstractFieldFactoryTestCase
    {
        [ClassInitialize]
        public static void Init(TestContext context)
        {
            BaseInit(context);
        }

        protected override IFieldFactory GetFactory()
        {
            return FieldFactory.Instance;
        }
    }
}
