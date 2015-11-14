using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Interfaces;
using BattleChess.Utilities;

namespace BattleChessUnitTests.MockedObjects
{
    public abstract class MockedChessPiece : IChessPiece
    {
        protected MockedChessPiece(IMovePattern movePattern, ColorType color)
        {
            this.MovePattern = movePattern;
            this.Color = color;
        }

        public abstract IChessPiece Create();

        public ICollection<IMove> PossibleMoves { get; private set; }

        public IField Field { get; private set; }

        public IAttack Attack { get; private set; }

        public IDefense Defence { get; private set; }

        private IMovePattern MovePattern { get; set; }

        public bool IsDead { get; private set; }

        public int Health { get; private set; }

        public int Mana { get; private set; }

        public ColorType Color { get; private set; }

        public void AddHealth(int healthValue)
        {
            throw new NotImplementedException();
        }

        public void AddMana(int manaValue)
        {
            throw new NotImplementedException();
        }

        public void GeneratePossibleMoves()
        {
            throw new NotImplementedException();
        }
    }
}
