using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Infrastructure;
using BattleChess.Interfaces;

namespace BattleChessUnitTests.MockedObjects
{
    public class MockedChessBoard : IChessBoard
    {
        private readonly Dictionary<IPosition, IField> chessBoard;

        public MockedChessBoard()
        {
            this.chessBoard = new Dictionary<IPosition, IField>();
            this.PopulateChessBoard();
        }

        public IField GetFieldAt(IPosition position)
        {
            return this.chessBoard[position];
        }

        private void PopulateChessBoard()
        {
            //TODO: Implement
        }
    }
}
