namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Prince_Gift : EgoGift_Hand_2
    {
        // Singleton instance
        private static readonly Prince_Gift _instance = new Prince_Gift();

        // Public accessor
        public static Prince_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Prince_Gift() : base(
            origin: Prince.Instance,
            name: "Spore",
            unlockLevel: 3,
            secondaryStats: new SecondaryStats(SP: 5, SR: 2, WS: 2)
        )
        { }
    }
}