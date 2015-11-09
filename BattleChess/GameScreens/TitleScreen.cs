namespace BattleChess.GameScreens
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using MonoGameBattleChessLibrary;
    using Utilities;

    public class TitleScreen : BaseGameState
    {
        private Texture2D backgroundImage;

        public TitleScreen(Game game, GameStateManager manager) 
            : base(game, manager)
        {
        }

        protected override void LoadContent()
        {
            this.backgroundImage = Images.TitleScreen;

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            this.engineRef.SpriteBatch.Begin();

            base.Draw(gameTime);
            this.engineRef.SpriteBatch.Draw(
                this.backgroundImage,
                this.engineRef.ScreenRectangle,
                Color.White);

            this.engineRef.SpriteBatch.End();
        }
    }
}
