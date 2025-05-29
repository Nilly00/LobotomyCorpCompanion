namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Porccubus_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Porccubus_Gift _instance = new();

        // Public accessor
        public static Porccubus_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Porccubus_Gift() : base(
            origin: Porccubus.Instance,
            name: "Pleasure",
            unlockLevel: 2,

            slot: Slot.Neckwear,
            secondaryStats: new SecondaryStats(SP: 10, SR: -6, WS: -6)
        )
        { }
    }
}