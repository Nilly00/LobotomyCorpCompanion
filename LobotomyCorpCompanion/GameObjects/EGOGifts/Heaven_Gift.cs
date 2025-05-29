namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Heaven_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Heaven_Gift _instance = new();

        // Public accessor
        public static Heaven_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Heaven_Gift() : base(
            origin: Heaven.Instance,
            name: "Heaven",
            unlockLevel: 3,

            slot: Slot.Helmet,
            secondaryStats: new SecondaryStats(HP: 4, SR: 2, WS: 2)
        )
        { }
    }
}