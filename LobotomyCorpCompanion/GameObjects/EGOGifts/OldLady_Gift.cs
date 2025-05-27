namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class OldLady_Gift : EgoGift
    {
        // Singleton instance
        private static readonly OldLady_Gift _instance = new OldLady_Gift();

        // Public accessor
        public static OldLady_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private OldLady_Gift() : base(
            origin: OldLady.Instance,
            name: "Solitude",
            unlockLevel: 2,

            slot: Slot.Eye,
            secondaryStats: new SecondaryStats(SR: 3, WS: 3)
        )
        { }
    }
}