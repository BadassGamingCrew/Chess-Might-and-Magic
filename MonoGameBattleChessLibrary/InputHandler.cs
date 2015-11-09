namespace MonoGameBattleChessLibrary
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;

    public class InputHandler : GameComponent
    {
        public InputHandler(Game game) : base(game)
        {
            KeyboardState = Keyboard.GetState();
        }

        public static KeyboardState KeyboardState { get; set; }

        public static KeyboardState LastKeyboardState { get; set; }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            LastKeyboardState = KeyboardState;
            KeyboardState = Keyboard.GetState();

            base.Update(gameTime);
        }

        public static void Flush()
        {
            LastKeyboardState = KeyboardState;
        }

        public static bool KeyReleased(Keys key)
        {
            return KeyboardState.IsKeyUp(key) && LastKeyboardState.IsKeyDown(key);
        }

        public static bool KeyPressed(Keys key)
        {
            return KeyboardState.IsKeyDown(key) && LastKeyboardState.IsKeyUp(key);
        }

        public static bool KeyDown(Keys key)
        {
            return KeyboardState.IsKeyDown(key);
        }
    }
}
