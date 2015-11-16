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
    public class MockedPawnChessPiece : MockedChessPiece
    {
        private static readonly IMovePattern MovePattern = PawnMovePattern.Instance;
        /// <summary>
        /// Pawn Chess Piece constructor. Takes ColorType as argument
        /// </summary>
        /// <param name="color">ColorType value for the current ChessPiece</param>
        public MockedPawnChessPiece(ColorType color) 
            : base(MovePattern, color)
        {
        }

        public override IChessPiece Create()
        {
            throw new System.NotImplementedException();
        }
    }
}
