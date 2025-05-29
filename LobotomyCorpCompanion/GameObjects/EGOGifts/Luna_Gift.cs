namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Luna_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Luna_Gift _instance = new();

        // Public accessor
        public static Luna_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Luna_Gift() : base(
            origin: Luna.Instance,
            name: "Moonlight",
            unlockLevel: 3,

            slot: Slot.Brooch,
            secondaryStats: new SecondaryStats(1, 1, 1, 1, 1, 1)
        )
        { }
    }
}