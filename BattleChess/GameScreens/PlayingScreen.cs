using BattleChess.Core;

namespace BattleChess.GameScreens
{
    using BattleChess.Infrastructure;
    using BattleChess.Interfaces;
    using Microsoft.Xna.Framework;
    using MonoGameBattleChessLibrary;

    public class PlayingScreen : BaseGameState
    {
        private readonly IChessBoard drawableGameObject;

        public PlayingScreen(GameEngine game, GameStateManager manager) 
            : base(game, manager)
        {
            this.drawableGameObject = new ChessBoard();
            this.drawableGameObject.MakeDrawable(game);
        }

        public override void Initialize()
        {
            this.drawableGameObject.DrawAttribute.Initialize();
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            this.drawableGameObject.DrawAttribute.Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            this.drawableGameObject.DrawAttribute.Draw(gameTime);
            base.Draw(gameTime);
        }
    }
}
