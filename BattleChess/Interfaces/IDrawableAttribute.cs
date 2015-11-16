using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Core;
using Microsoft.Xna.Framework;

namespace BattleChess.Interfaces
{
    public interface IDrawableAttribute
    {
        bool DrawableAttributeSet { get; }
        void MakeDrawable(GameEngine game);
        IDrawableGameObject DrawAttribute { get; }
    }
}
