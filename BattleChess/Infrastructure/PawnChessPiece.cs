﻿// <auto-generated />

using BattleChess.Core;

namespace BattleChess.Infrastructure
{
    using Interfaces;
    using Utilities;

    /// <summary>
    /// Concrete implementation of IChessPiece. Extends ChessPiece
    /// </summary>
    public class PawnChessPiece : ChessPiece
    {
        /// <summary>
        /// Pawn Chess Piece constructor. Takes ColorType as argument
        /// </summary>
        /// <param name="color">ColorType value for the current ChessPiece</param>
        public PawnChessPiece(ColorType color) 
            : base(GameEngine.Instance, PawnMovePattern.Instance, color)
        {
        }

        public override IChessPiece Create()
        {
            throw new System.NotImplementedException();
        }
    }
}
