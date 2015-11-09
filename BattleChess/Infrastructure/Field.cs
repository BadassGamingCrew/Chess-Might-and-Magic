﻿// <auto-generated />
namespace BattleChess.Infrastructure
{
    using Interfaces;
    using Utilities;

    /// <summary>
    /// Abstarct class for Field objects
    /// </summary>
    public abstract class Field : IField
    {
        /// <summary>
        /// Field constructor that takes an IPosition object as argument
        /// </summary>
        /// <param name="position">The position for the current IField object</param>
        /// <param name="color">The color for the current IField object</param>
        /// <param name="chessBoard">The chess board for the current IField object</param>
        protected Field(IPosition position, ColorType color, IChessBoard chessBoard)
        {
            this.ChessBoard = chessBoard;
            this.Position = position;
            this.Color = color;
            this.HasChessPiece = false;
        }

        public IChessBoard ChessBoard { get; private set; }

        public IPosition Position { get; set; }

        public IChessPiece ChessPiece { get; set; }

        public bool HasChessPiece { get; private set; }

        public ColorType Color { get; private set; }

        public abstract IField Create();
    }
}
