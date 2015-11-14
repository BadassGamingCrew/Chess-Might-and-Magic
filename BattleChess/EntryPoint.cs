using BattleChess.Infrastructure;
using BattleChess.Interfaces;
using BattleChess.Utilities;

namespace BattleChess
{
    using System;
    using Core;

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
            using (var game = GameEngine.Instance)
            {
                game.Run();
            }
        }
    }
#endif
}
