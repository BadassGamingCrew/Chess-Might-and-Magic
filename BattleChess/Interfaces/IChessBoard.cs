﻿// <auto-generated />

namespace BattleChess.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using BattleChess.Infrastructure;

    /// <summary>
    /// Interface for Chess Board objects
    /// </summary>
    public interface IChessBoard : IGameComponent, IDrawable, IUpdateable, IDictionary<Position, IField>
    {
        /// <summary>
        /// Moves a chess piece from given position to another. If the second is not null, the piece attacks.
        /// </summary>
        /// <param name="from">The position of the chess piece.</param>
        /// <param name="to">The position to be moved.</param>
        /// <exception cref="ArgumentNullException">If there is no piece in the given position.</exception>
        void Move(Position from, Position to);
    }
}
