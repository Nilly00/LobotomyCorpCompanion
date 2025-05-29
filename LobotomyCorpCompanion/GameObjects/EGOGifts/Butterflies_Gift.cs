namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Butterflies_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Butterflies_Gift _instance = new();

        // Public accessor
        public static Butterflies_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Butterflies_Gift() : base(
            origin: Butterflies.Instance,
            name: "Solemn Lament",
            unlockLevel: 3,

            slot: Slot.Right_back,
            secondaryStats: new SecondaryStats(1, 1, 1, 1, 1, 1)
        )
        { }
    }
}