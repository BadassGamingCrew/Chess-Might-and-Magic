﻿// <auto-generated />
namespace BattleChess.Interfaces
{
    /// <summary>
    /// Interface for Move objects.
    /// </summary>
    public interface IMove : IExecutable
    {
        /// <summary>
        /// Sets/Gets the From IField object
        /// </summary>
        IField From { set; get; }

        /// <summary>
        /// Sets/Gets the Destination IField object
        /// </summary>
        IField To { set; get; }
    }
}
