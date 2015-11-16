﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleChess.Interfaces
{
    public interface IGameObject : IEquatable<IGameObject>
    {
        bool IsDrawable { get; }
    }
}
