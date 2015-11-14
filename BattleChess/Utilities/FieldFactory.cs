using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Infrastructure;
using BattleChess.Interfaces;

namespace BattleChess.Utilities
{
    public class FieldFactory : IFieldFactory
    {
        public static readonly IFieldFactory Instance = new FieldFactory();

        private FieldFactory()
        {
            //Singleton - Ref. Singleton [GOF]
        }

        public IField Create(IPosition position, ColorType color, IChessBoard chessBoard)
        {
            switch (color)
            {
                case ColorType.Black:
                    return new BlackField(position, chessBoard);
                case ColorType.White:
                    return new WhiteField(position, chessBoard);
                default:
                    throw new ArgumentOutOfRangeException("color", ErrorMessages.InvalidColor);
            }
        }
    }
}
