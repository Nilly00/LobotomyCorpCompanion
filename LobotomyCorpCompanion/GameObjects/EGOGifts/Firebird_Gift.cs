namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Firebird_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Firebird_Gift _instance = new Firebird_Gift();

        // Public accessor
        public static Firebird_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Firebird_Gift() : base(
            origin: Firebird.Instance,
            name: "Feather of Honor",
            unlockLevel: 3,

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(SP: 2, AS: 4, MS: 4)
        )
        { }
    }
}