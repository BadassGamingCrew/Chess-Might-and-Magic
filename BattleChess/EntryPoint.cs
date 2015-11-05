namespace BattleChess
{
    using System;
    using BattleChess.Core;

#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class EntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new GameEngine())
            {
                game.Run();
            }
        }
    }
#endif
}
