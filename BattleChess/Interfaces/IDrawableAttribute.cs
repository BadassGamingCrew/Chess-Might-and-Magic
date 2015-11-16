using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleChess.Interfaces
{
    public interface IDrawableAttribute
    {
        bool DrawableAttributeSet { get; }
        void MakeDrawable();
        IDrawableGameObject DrawAttribute { get; }
    }
}
