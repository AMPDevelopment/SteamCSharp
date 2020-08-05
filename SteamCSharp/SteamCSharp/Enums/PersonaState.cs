namespace SteamCSharp.Enums
{
    /// <summary>
    /// Represents persona state.
    /// </summary>
    public enum PersonaState
    {
        /// <summary>
        /// Persona is offline.
        /// </summary>
        Offline = 0,

        /// <summary>
        /// Persona is online.
        /// </summary>
        Online = 1,
        
        /// <summary>
        /// Persona is busy.
        /// </summary>
        Busy = 2,

        /// <summary>
        /// Persona is away.
        /// </summary>
        Away = 3,

        /// <summary>
        /// Persona is snoozing.
        /// </summary>
        Snooze = 4,

        /// <summary>
        /// Persona is looking to trade.
        /// </summary>
        LookingToTrade = 5,

        /// <summary>
        /// Persona is looking to play.
        /// </summary>
        LookingToPlay = 6
    }
}
