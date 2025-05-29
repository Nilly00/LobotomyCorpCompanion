namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Bald_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Bald_Gift _instance = new();

        // Public accessor
        public static Bald_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bald_Gift() : base(
            origin: Bald.Instance,
            name: "Tough",
            unlockLevel: 3,

            slot: Slot.Eye,
            secondaryStats: new SecondaryStats(AS: 2, MS: 2)
        )
        { }
    }
}