namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Star_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Star_Gift _instance = new();

        // Public accessor
        public static Star_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Star_Gift() : base(
            origin: Star.Instance,
            name: "Sound of a Star",
            unlockLevel: 4,

            slot: Slot.Eye,
            secondaryStats: new SecondaryStats(MS: 10)
        )
        { }
    }
}