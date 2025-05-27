namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Shy_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Shy_Gift _instance = new Shy_Gift();

        // Public accessor
        public static Shy_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Shy_Gift() : base(
            origin: Shy.Instance,
            name: "Today's Expression",
            unlockLevel: 2,

            slot: Slot.Eye,
            secondaryStats: new SecondaryStats(SP: -2, SR: 4, WS: 4)
        )
        { }
    }
}