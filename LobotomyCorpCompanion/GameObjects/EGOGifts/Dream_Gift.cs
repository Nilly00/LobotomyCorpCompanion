namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Dream_Gift : EgoGift_Hat
    {
        // Singleton instance
        private static readonly Dream_Gift _instance = new Dream_Gift();

        // Public accessor
        public static Dream_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Dream_Gift() : base(
            origin: Dream.Instance,
            name: "Engulfing Dream",
            unlockLevel: 2,
            secondaryStats: new SecondaryStats(SP: 4)
        )
        { }
    }
}