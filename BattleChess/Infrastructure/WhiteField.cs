﻿// <auto-generated />
namespace BattleChess.Infrastructure
{
    using Interfaces;
    using Utilities;

    /// <summary>
    /// Concrete implementation of IField. Extends Field
    /// </summary>
    public class WhiteField : Field
    {
        private static readonly ColorType Color = ColorType.White;
        /// <summary>
        /// Constructor for BlackField that takes an IPosition and IChessBoard objects as arguments.
        /// Calls Field contructor with the IPosition object, the ColorType.White value and the IChessBoard object
        /// </summary>
        /// <param name="position">The IPosition object for this field</param>
        /// <param name="chessBoard">The IChessBoard object for this field</param>
        public WhiteField(IPosition position, IChessBoard chessBoard)
            : base(position, Color, chessBoard)
        {
        }
    }
}
