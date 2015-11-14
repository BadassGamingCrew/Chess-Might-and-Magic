using BattleChess.Core;

namespace BattleChess.GameScreens
{
    using BattleChess.Infrastructure;
    using BattleChess.Interfaces;
    using Microsoft.Xna.Framework;
    using MonoGameBattleChessLibrary;

    public class PlayingScreen : BaseGameState
    {
        private static readonly Game Engine = GameEngine.Instance;
        private readonly IChessBoard chessBoard;

        public PlayingScreen(GameStateManager manager) 
            : base(Engine, manager)
        {
            this.chessBoard = new ChessBoard();
        }

        public override void Initialize()
        {
            //TODO: Add exception if the field does not implement IGameComponent
            ((IGameComponent)this.chessBoard).Initialize();
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            //TODO: Add exception if the field does not implement IUpdateable
            ((IUpdateable)this.chessBoard).Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            //TODO: Add exception if the field does not implement IDrawable
            ((IDrawable)this.chessBoard).Draw(gameTime);
            base.Draw(gameTime);
        }
    }
}
