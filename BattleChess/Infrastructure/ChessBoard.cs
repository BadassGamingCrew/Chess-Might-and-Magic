﻿// <auto-generated />
namespace BattleChess.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using BattleChess.Interfaces;
    using BattleChess.Core;
    using Microsoft.Xna.Framework;

    /// <summary>
    /// Concrete implementation of IChessBoard. Extends DrawableGameComponent
    /// </summary>
    public class ChessBoard : DrawableGameComponent, IChessBoard
    {
        private readonly GameEngine engine;
        private readonly Dictionary<Position, IField> chessBoard = new Dictionary<Position, IField>(); 

        /// <summary>
        /// ChessBoard constructor
        /// </summary>
        /// <param name="game"></param>
        public ChessBoard(Game game) 
            : base(game)
        {
            this.engine = game as GameEngine;


        }

        public IField GetFieldAt(IPosition position)
        {
                throw new NotImplementedException();
            
        }

        public override void Initialize()
        {
            //TODO
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (IField field in this.chessBoard.Values)
            {
                field.Update(gameTime);
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            this.engine.SpriteBatch.Begin();
            base.Draw(gameTime);

            foreach (IField field in this.chessBoard.Values)
            {
                field.Draw(gameTime);
            }

            foreach (IField field in this.chessBoard.Values)
            {
                if (field.ChessPiece != null)
                {
                    field.ChessPiece.Draw(gameTime);   
                }
            }

            this.engine.SpriteBatch.End();
        }
    }
}
