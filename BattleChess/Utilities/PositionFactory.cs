using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleChess.Infrastructure;
using BattleChess.Interfaces;

namespace BattleChess.Utilities
{
    public class PositionFactory : IPositionFactory
    {
        public static readonly PositionFactory Instance = new PositionFactory();
        private readonly Validator Validator;
        private readonly string invalidColumnMessage;
        private readonly string invalidRowMessage;

        private PositionFactory()
        {
            //Singleton - Ref. Singleton [GOF]
            this.Validator = Validator.Instance;
            this.invalidColumnMessage = ErrorMessages.InvalidColumn;
            this.invalidRowMessage = ErrorMessages.InvalidRow;
        }

        public IPosition Create(char column, int row)
        {
            this.Validator.ValidatePositionParameters(column, row, this.invalidColumnMessage, this.invalidRowMessage);
            return new Position(column, row);
        }
    }
}
