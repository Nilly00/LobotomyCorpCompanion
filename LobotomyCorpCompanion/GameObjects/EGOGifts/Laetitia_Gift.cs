namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Laetitia_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Laetitia_Gift _instance = new Laetitia_Gift();

        // Public accessor
        public static Laetitia_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Laetitia_Gift() : base(
            origin: Laetitia.Instance,
            name: "Laetitia",
            unlockLevel: 3,

            slot: Slot.Helmet,
            secondaryStats: new SecondaryStats(SP: 4)
        )
        { }
    }
}