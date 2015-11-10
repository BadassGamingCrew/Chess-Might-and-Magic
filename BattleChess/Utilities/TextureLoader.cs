using BattleChess.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BattleChess.Utilities
{
    public class TextureLoader : GameComponent
    {
        private readonly GameEngine game;

        public TextureLoader(Game game) 
            : base(game)
        {
            this.game = game as GameEngine;
        }

        public override void Initialize()
        {
            base.Initialize();
            this.LoadAllImages();
        }


        private Texture2D LoadImage(string path)
        {
            return this.game.Content.Load<Texture2D>(path);
        }

        private void LoadAllImages()
        {
            Images.TitleScreen = this.LoadImage(Paths.TitleScreen);
            Images.ChessBoard = this.LoadImage(Paths.Chessboard);
        }
    }
}
