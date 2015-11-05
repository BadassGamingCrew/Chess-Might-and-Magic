namespace MonoGameBattleChessLibrary
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;

    public class GameStateManager : GameComponent
    {
        private const int startDrawOrder = 5000;
        private const int drawOrderInc = 100;
        private int drawOrder;

        public event EventHandler OnStateChange;

        public readonly Stack<GameState> gameStates = new Stack<GameState>();

        public GameStateManager(Game game)
            : base(game)
        {
            this.drawOrder = startDrawOrder;
        }

        public GameState CurrentState
        {
            get
            {
                return this.gameStates.Peek();
            }
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public void PopState()
        {
            if (gameStates.Count > 0)
            {
                RemoveState();
                this.drawOrder -= drawOrderInc;

                if (this.OnStateChange != null)
                {
                    this.OnStateChange(this, null);
                }
            }
        }

        public void PushState(GameState newState)
        {
            this.drawOrder += drawOrderInc;
            newState.DrawOrder = this.drawOrder;

            AddState(newState);

            if (this.OnStateChange != null)
            {
                this.OnStateChange(this, null);
            }
        }

        public void ChangeState(GameState newState)
        {
            while (this.gameStates.Count > 0)
            {
                this.RemoveState();
            }

            newState.DrawOrder = startDrawOrder;
            this.drawOrder = startDrawOrder;

            this.AddState(newState);

            if (this.OnStateChange != null)
            {
                this.OnStateChange(this, null);
            }
        }

        private void AddState(GameState newState)
        {
            this.gameStates.Push(newState);

            this.Game.Components.Add(newState);

            this.OnStateChange += newState.StateChange;
        }

        private void RemoveState()
        {
            GameState state = this.gameStates.Peek();

            this.OnStateChange -= state.StateChange;
            this.Game.Components.Remove(state);
            this.gameStates.Pop();
        }
    }
}