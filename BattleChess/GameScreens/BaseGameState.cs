namespace BattleChess.GameScreens
{
    using Core;
    using Microsoft.Xna.Framework;
    using MonoGameBattleChessLibrary;

    public abstract partial class BaseGameState : GameState
    {
        protected GameEngine engineRef;

        protected BaseGameState(Game game, GameStateManager manager)
            : base(game, manager)
        {
            this.engineRef = game as GameEngine;
        }
    }
}
