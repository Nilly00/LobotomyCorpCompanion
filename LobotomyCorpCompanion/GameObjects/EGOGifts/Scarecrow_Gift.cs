namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Scarecrow_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Scarecrow_Gift _instance = new();

        // Public accessor
        public static Scarecrow_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Scarecrow_Gift() : base(
            origin: Scarecrow.Instance,
            name: "Harvest",
            unlockLevel: 2,

            slot: Slot.Neckwear,
            secondaryStats: new SecondaryStats(SP: 4)
        )
        { }
    }
}