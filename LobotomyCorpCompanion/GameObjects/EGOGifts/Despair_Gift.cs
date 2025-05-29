namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Despair_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Despair_Gift _instance = new();

        // Public accessor
        public static Despair_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Despair_Gift() : base(
            origin: Despair.Instance,
            name: "The Sword Sharpened with Tears",
            unlockLevel: 3,

            slot: Slot.Cheek,
            secondaryStats: new SecondaryStats(SP: 2, AS: 4, MS: 4)
        )
        { }
    }
}