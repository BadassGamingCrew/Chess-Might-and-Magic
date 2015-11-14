using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Utilities;

namespace BattleChess.Interfaces
{
    public interface IFieldFactory
    {
        IField Create(IPosition position, ColorType color, IChessBoard chessBoard);
    }
}
