namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class White_Gift : EgoGift
    {
        // Singleton instance
        private static readonly White_Gift _instance = new();

        // Public accessor
        public static White_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private White_Gift() : base(
            origin: White.Instance,
            unlockLevel: 0,
            name: "Paradise Lost",

            slot: Slot.Left_back,
            secondaryStats: new SecondaryStats(HP: 10, SP: 10, AS: 10, MS: 10)
        )
        { }
    }
}