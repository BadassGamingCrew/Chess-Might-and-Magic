using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Core;
using BattleChess.Interfaces;
using Microsoft.Xna.Framework;

namespace BattleChess.Infrastructure
{
    public class DrawableChessPiece : DrawableGameObject
    {
        private IChessPiece chessPiece;

        public DrawableChessPiece(GameEngine game, IChessPiece gameObject) 
            : base(game, gameObject)
        {
            this.chessPiece = gameObject;
        }

        public override bool Equals(IGameObject other)
        {
            return TypeIsSame(other) && ObjectIsSame((IChessPiece) other);
        }

        public override void UpdateGameObject(IGameObject gameObject)
        {
            if (!this.Equals(gameObject))
            {
                this.chessPiece = gameObject as IChessPiece;
            }
        }

        private bool TypeIsSame(IGameObject other)
        {
            return other is IChessPiece;
        }

        private bool ObjectIsSame(IChessPiece other)
        {
            return this.chessPiece.Equals(other);
        }
    }
}
