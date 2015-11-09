namespace MonoGameBattleChessLibrary
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;

    public abstract partial class GameState : DrawableGameComponent
    {
        private readonly List<GameComponent> childComponents;

        private readonly GameState tag;

        protected GameStateManager stateManager;

        protected GameState(Game game, GameStateManager manager)
            : base(game)
        {
            this.stateManager = manager;
            this.childComponents = new List<GameComponent>();
            this.tag = this;
        }

        public List<GameComponent> Components
        {
            get
            {
                return this.childComponents;
            }
        }

        public GameState Tag
        {
            get
            {
                return this.tag;
            }
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            this.childComponents.ForEach((c) =>
            {
                if (c.Enabled)
                {
                    c.Update(gameTime);
                }
            });

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            DrawableGameComponent drawableComponent;

            this.childComponents.ForEach((c) =>
            {
                if (c is DrawableGameComponent)
                {
                    drawableComponent = c as DrawableGameComponent;

                    if (drawableComponent.Visible)
                    {
                        drawableComponent.Draw(gameTime);
                    }
                }
            });

            base.Draw(gameTime);
        }

        internal protected virtual void StateChange(object sender, EventArgs e)
        {
            if (this.stateManager.CurrentState == Tag)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }
                
        private void Show()
        {
            this.Visible = true;
            this.Enabled = true;

            this.childComponents.ForEach((c) =>
            {
                c.Enabled = true;

                if (c is DrawableGameComponent)
                {
                    (c as DrawableGameComponent).Visible = true;
                }
            });
        }

        private void Hide()
        {
            this.Visible = false;
            this.Enabled = false;

            this.childComponents.ForEach((c) =>
            {
                c.Enabled = false;

                if (c is DrawableGameComponent)
                {
                    (c as DrawableGameComponent).Visible = false;
                }
            });
        }
    }
}
