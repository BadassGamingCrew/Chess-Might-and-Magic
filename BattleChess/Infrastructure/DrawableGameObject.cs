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
    public abstract class DrawableGameObject : DrawableGameComponent, IDrawableGameObject
    {
        protected static readonly GameEngine Engine = GameEngine.Instance;
        protected IGameObject gameObject;

        protected DrawableGameObject(IGameObject gameObject) 
            : base(Engine)
        {
            this.gameObject = gameObject;
        }

        public abstract bool Equals(IGameObject other);
        public abstract void UpdateGameObject(IGameObject gameObject);

        public bool IsDrawable
        {
            get { return this.gameObject.IsDrawable; }
        }
    }
}
