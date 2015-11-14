using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Interfaces;
using BattleChess.Utilities;

namespace BattleChessUnitTests.MockedObjects
{
    public abstract class MockedField : IField
    {
        protected MockedField(IPosition position, ColorType color, IChessBoard chessBoard)
        {
            this.ChessBoard = chessBoard;
            this.Position = position;
            this.Color = color;
            this.HasChessPiece = false;
        }

        public abstract IField Create();

        public IChessBoard ChessBoard { get; private set; }

        public IPosition Position { get; set; }

        public IChessPiece ChessPiece { get; set; }

        public bool HasChessPiece { get; private set; }

        public ColorType Color { get; private set; }
    }
}
