namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Alriune_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Alriune_Gift _instance = new Alriune_Gift();

        // Public accessor
        public static Alriune_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Alriune_Gift() : base(
            origin: Alriune.Instance,
            name: "Faint Aroma",
            unlockLevel: 2,

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(SP: 4, WS: 2)
        )
        { }
    }
}