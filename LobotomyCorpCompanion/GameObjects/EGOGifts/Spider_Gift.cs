namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Spider_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Spider_Gift _instance = new Spider_Gift();

        // Public accessor
        public static Spider_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Spider_Gift() : base(
            origin: Spider.Instance,
            name: "Red Eyes",
            unlockLevel: 2,

            slot: Slot.Eye,
            secondaryStats: new SecondaryStats(SR: 3, WS: 3)
        )
        { }
    }
}