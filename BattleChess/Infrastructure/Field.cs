using BattleChess.Core;

namespace BattleChess.Infrastructure
{
    using System;
    using BattleChess.Utilities;
    using BattleChess.Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Field : DrawableGameComponent, IField
    {
        private readonly GameEngine engine;
        private Texture2D texture;
        private Rectangle imageRectangle;
        private Vector2 positionVector2;

        public Field(Game game, Position position, IChessPiece chessPiece = null)
            : base(game)
        {
            this.engine = game as GameEngine;
            this.Position = position;
            this.Texture = Images.ChessBoard;
            this.ChessPiece = chessPiece;
            this.imageRectangle = this.GetImageRectangle();
            this.positionVector2 = GetVector2Position();
        }

      
        public Position Position { get; private set; }
        public IChessPiece ChessPiece { get; set; }

        public Texture2D Texture
        {
            get { return this.texture; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                this.texture = value;
            }
        }

        public override void Update(GameTime gameTime)
        {
            if (this.ChessPiece != null)
            {
                this.ChessPiece.Update(gameTime);                
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            this.engine.SpriteBatch.Draw(this.Texture, this.positionVector2, this.imageRectangle, Color.WhiteSmoke);
            base.Draw(gameTime);
        }

        IField IFactory<IField>.Create()
        {
            throw new System.NotImplementedException();
        }

        private Rectangle GetImageRectangle()
        {
            if (this.Position.Column % 2 == 0)
            {
                if (this.Position.Row % 2 == 0)
                {
                    return new Rectangle(61, 0, 60, 60);
                }
                else
                {
                    return new Rectangle(0, 0, 60, 60);
                }
            }
            else
            {
                if (this.Position.Row % 2 == 0)
                {
                    return new Rectangle(0, 0, 60, 60);
                }
                else
                {
                    return new Rectangle(61, 0, 60, 60);
                }
            }
        }

        private Vector2 GetVector2Position()
        {
            return new Vector2((this.Position.Column - 'A') * 60, (8 - this.Position.Row) * 60);
        }
    }
}
