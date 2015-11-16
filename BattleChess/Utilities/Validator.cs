using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleChess.Utilities
{
    public class Validator
    {
        public static readonly Validator Instance = new Validator();

        private Validator()
        {
            //Singleton - Ref. Singleton [GOF]
        }

        public void ValidatePositionParameters(char column, int row, string columnErrormessage,
            string rowErrorMessage)
        {
            ValidatePositionColumn(column, columnErrormessage);
            ValidatePositionRow(row, rowErrorMessage);
        }

        private void ValidatePositionColumn(char column, string errorMessage)
        {
            if (column < 'A' || column > 'H')
            {
                throw new ArgumentOutOfRangeException("column", errorMessage);
            }
        }

        private void ValidatePositionRow(int row, string errorMessage)
        {
            if (row < 1 || row > 8)
            {
                throw new ArgumentOutOfRangeException("row", errorMessage);
            }
        }
    }
}
