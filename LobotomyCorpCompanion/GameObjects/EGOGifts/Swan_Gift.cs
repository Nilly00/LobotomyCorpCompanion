namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Swan_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Swan_Gift _instance = new Swan_Gift();

        // Public accessor
        public static Swan_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Swan_Gift() : base(
            origin: Swan.Instance,
            unlockLevel: 3,
            name: "Black Swan",

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(HP: -4, SP: -4, SR: +10, WS: +10)
        )
        { }
    }
}