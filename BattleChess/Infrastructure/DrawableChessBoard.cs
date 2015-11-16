using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Interfaces;
using Microsoft.Xna.Framework;

namespace BattleChess.Infrastructure
{
    public class DrawableChessBoard : DrawableGameObject
    {
        private IChessBoard chessBoard;

        public DrawableChessBoard(IChessBoard chessBoard)
            : base(chessBoard)
        {
            this.chessBoard = chessBoard;
        }

        public override void Update(GameTime gameTime)
        {
            foreach (IField field in this.chessBoard.GetAllFields())
            {
                field.DrawAttribute.Update(gameTime);
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            Engine.SpriteBatch.Begin();
            base.Draw(gameTime);

            foreach (IField field in this.chessBoard.GetAllFields())
            {
                field.DrawAttribute.Draw(gameTime);
            }

            //TODO: This should be delegated to the IField object otherwise we break the Law Of Demeter
            foreach (IField field in this.chessBoard.GetAllFields())
            {
                if (field.ChessPiece != null)
                {
                    field.ChessPiece.DrawAttribute.Draw(gameTime);
                }
            }

            Engine.SpriteBatch.End();
        }

        public override bool Equals(IGameObject other)
        {
            return TypeIsSame(other) && ObjectIsSame((IChessBoard) other);
        }

        public override void UpdateGameObject(IGameObject gameObject)
        {
            if (!this.Equals(gameObject))
            {
                this.chessBoard = gameObject as IChessBoard;
            }
        }

        private bool TypeIsSame(IGameObject other)
        {
            return other is IChessBoard;
        }

        private bool ObjectIsSame(IChessBoard other)
        {
            return this.chessBoard.Equals(other);
        }
    }
}
