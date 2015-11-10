namespace BattleChess.GameScreens
{
    using BattleChess.Infrastructure;
    using BattleChess.Interfaces;
    using Microsoft.Xna.Framework;
    using MonoGameBattleChessLibrary;

    public class PlayingScreen : BaseGameState
    {
        private readonly IChessBoard chessBoard;

        public PlayingScreen(Game game, GameStateManager manager) 
            : base(game, manager)
        {
            this.chessBoard = new ChessBoard(game);
        }

        public override void Initialize()
        {
            this.chessBoard.Initialize();
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            this.chessBoard.Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            this.chessBoard.Draw(gameTime);
            base.Draw(gameTime);
        }
    }
}
