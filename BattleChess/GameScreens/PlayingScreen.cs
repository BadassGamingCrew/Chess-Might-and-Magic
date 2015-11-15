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
        private readonly IChessBoard drawableGameObject;

        public PlayingScreen(GameStateManager manager) 
            : base(Engine, manager)
        {
            this.drawableGameObject = new ChessBoard();
            this.drawableGameObject.MakeDrawable();
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
