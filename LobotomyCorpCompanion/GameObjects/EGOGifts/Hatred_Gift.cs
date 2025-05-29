namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Hatred_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Hatred_Gift _instance = new();

        // Public accessor
        public static Hatred_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Hatred_Gift() : base(
            origin: Hatred.Instance,
            name: "In the Name of Love and Hate",
            unlockLevel: 3,

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(SR: 2, WS: 2, AS: 4, MS: 4)
        )
        { }
    }
}