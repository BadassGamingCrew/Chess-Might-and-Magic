namespace BattleChess.Infrastructure
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using BattleChess.Interfaces;
    using BattleChess.Core;
    using Microsoft.Xna.Framework;

    public class ChessBoard : DrawableGameComponent, IChessBoard
    {
        private readonly GameEngine engine;
        private readonly Dictionary<Position, IField> chessBoard = new Dictionary<Position, IField>(); 

        public ChessBoard(Game game) 
            : base(game)
        {
            this.engine = game as GameEngine;


        }
        
        public IEnumerator<KeyValuePair<Position, IField>> GetEnumerator()
        {
            return this.chessBoard.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(KeyValuePair<Position, IField> item)
        {
            this.chessBoard.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            this.chessBoard.Clear();
        }

        public bool Contains(KeyValuePair<Position, IField> item)
        {
            return this.chessBoard.Contains(item);
        }

        public void CopyTo(KeyValuePair<Position, IField>[] array, int arrayIndex)
        {
            foreach (KeyValuePair<Position, IField> pair in this.chessBoard)
            {
                array[arrayIndex++] = pair;
            }
        }

        public bool Remove(KeyValuePair<Position, IField> item)
        {
            return this.chessBoard.Remove(item.Key);
        }

        public int Count
        {
            get { return this.chessBoard.Count; }
        }

        public bool IsReadOnly
        {
            get { return (this.chessBoard as ICollection<KeyValuePair<Position, IField>>).IsReadOnly; }
        }

        public bool ContainsKey(Position key)
        {
            return this.chessBoard.ContainsKey(key);
        }

        public void Add(Position key, IField value)
        {
            this.chessBoard.Add(key, value);
        }

        public bool Remove(Position key)
        {
            return this.chessBoard.Remove(key);
        }

        public bool TryGetValue(Position key, out IField value)
        {
            return this.chessBoard.TryGetValue(key, out value);
        }

        public IField this[Position key]
        {
            get { return this.chessBoard[key]; }
            set { this.chessBoard[key] = value; }
        }

        public ICollection<Position> Keys
        {
            get { return this.chessBoard.Keys; }
        }
        public ICollection<IField> Values {
            get
            {
                return this.chessBoard.Values;
            }
        }
     
        public void Move(Position from, Position to)
        {
            if (this[from].ChessPiece == null)
            {
                throw new ArgumentNullException("from");
            }

            if (this[to].ChessPiece == null)
            {
                this[to].ChessPiece = this[from].ChessPiece;
                this[from].ChessPiece = null;
            }
            else
            {
                //TODO: The attack logic.
                throw new NotImplementedException();
            }
        }

        public override void Initialize()
        {
            for (char column = 'A'; column <= 'H'; column++)
            {
                for (int row = 1; row <= 8; row++)
                {
                    Position currentPosition = new Position(column, row);
                    IField currentField = new Field(this.Game, currentPosition);
                    this[currentPosition] = currentField;
                }
            }
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (IField field in this.Values)
            {
                field.Update(gameTime);
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            this.engine.SpriteBatch.Begin();
            base.Draw(gameTime);

            foreach (IField field in this.Values)
            {
                field.Draw(gameTime);
            }

            foreach (IField field in this.Values)
            {
                if (field.ChessPiece != null)
                {
                    field.ChessPiece.Draw(gameTime);   
                }
            }

            this.engine.SpriteBatch.End();
        }
    }
}
