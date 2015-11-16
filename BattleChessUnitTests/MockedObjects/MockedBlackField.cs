using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Infrastructure;
using BattleChess.Interfaces;
using BattleChess.Utilities;

namespace BattleChessUnitTests.MockedObjects
{
    public class MockedBlackField : MockedField
    {
        private static readonly ColorType Color = ColorType.Black;
        /// <summary>
        /// Constructor for BlackField that takes an IPosition and IChessBoard objects as arguments.
        /// Calls Field contructor with the IPosition object, the ColorType.Black value and the IChessBoard object
        /// </summary>
        /// <param name="position">The IPosition object for this field</param>
        /// <param name="chessBoard">The IChessBoard object for this field</param>
        public MockedBlackField(IPosition position, IChessBoard chessBoard)
            : base(position, Color, chessBoard)
        {
        }

        public override IField Create()
        {
            return new MockedBlackField(this.Position, this.ChessBoard);
        }
    }
}
