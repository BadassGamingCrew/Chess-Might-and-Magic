namespace BattleChess.Infrastructure
{
    using System;

    /// <summary>
    /// Position on the Chess board.
    /// </summary>
    public struct Position
    {
        private char column;
        private int row;

        public Position(char column, int row) 
            : this()
        {
            this.Column = column;
            this.Row = row;
        }


        public char Column
        {
            get { return this.column; }

            private set
            {
                if (value < 'A' || value > 'H')
                {
                    throw new ArgumentException("The column must be between A and H!", "column");
                }
                this.column = value;
            }
        }

        public int Row
        {
            get { return this.row; }

            private set
            {
                if (value < 1 || value > 8)
                {
                    throw new ArgumentException("The row must be between 1 and 8!", "row");
                }
                this.row = value;
            }
        }
    }
}