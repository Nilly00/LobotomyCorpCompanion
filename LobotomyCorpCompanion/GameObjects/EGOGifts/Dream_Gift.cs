namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Dream_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Dream_Gift _instance = new();

        // Public accessor
        public static Dream_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Dream_Gift() : base(
            origin: Dream.Instance,
            name: "Engulfing Dream",
            unlockLevel: 2,

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(SP: 4)
        )
        { }
    }
}