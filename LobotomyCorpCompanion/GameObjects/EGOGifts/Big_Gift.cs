namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Big_Gift : EgoGift_Helmet
    {
        // Singleton instance
        private static readonly Big_Gift _instance = new Big_Gift();

        // Public accessor
        public static Big_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Big_Gift() : base(
            origin: Big.Instance,
            unlockLevel: 3,
            name: "Lamp",
            secondaryStats: new SecondaryStats(HP:3, SR: 3, WS: 3)
        )
        { }
    }
}