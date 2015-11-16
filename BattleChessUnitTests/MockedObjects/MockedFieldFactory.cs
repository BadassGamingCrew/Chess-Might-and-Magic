using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Interfaces;
using BattleChess.Utilities;

namespace BattleChessUnitTests.MockedObjects
{
    public class MockedFieldFactory : IFieldFactory
    {
        public static readonly IFieldFactory Instance = new MockedFieldFactory();

        private MockedFieldFactory()
        {
            //Singleton - Ref. Singleton [GOF]
        }

        public IField Create(IPosition position, ColorType color, IChessBoard chessBoard)
        {
            switch (color)
            {
                case ColorType.Black:
                    return new MockedBlackField(position, chessBoard);
                case ColorType.White:
                    return new MockedWhiteField(position, chessBoard);
                default:
                    throw new ArgumentOutOfRangeException("color", ErrorMessages.InvalidColor);
            }
        }
    }
}
