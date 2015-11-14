using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace BattleChess.Interfaces
{
    public interface IDrawableField : IField, IUpdateable, IDrawable
    {
    }
}
