namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Porccubus_Gift : EgoGift_Neckwear
    {
        // Singleton instance
        private static readonly Porccubus_Gift _instance = new Porccubus_Gift();

        // Public accessor
        public static Porccubus_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Porccubus_Gift() : base(
            origin: Porccubus.Instance,
            name: "Pleasure",
            unlockLevel: 2,
            secondaryStats: new SecondaryStats(SP: 10, SR: -6, WS: -6)
        )
        { }
    }
}