namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Prince_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Prince_Gift _instance = new();

        // Public accessor
        public static Prince_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Prince_Gift() : base(
            origin: Prince.Instance,
            name: "Spore",
            unlockLevel: 3,

            slot: Slot.Hand_2,
            secondaryStats: new SecondaryStats(SP: 5, SR: 2, WS: 2)
        )
        { }
    }
}