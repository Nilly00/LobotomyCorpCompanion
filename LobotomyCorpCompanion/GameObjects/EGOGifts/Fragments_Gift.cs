namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Fragments_Gift : EgoGift_Brooch
    {
        // Singleton instance
        private static readonly Fragments_Gift _instance = new Fragments_Gift();

        // Public accessor
        public static Fragments_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fragments_Gift() : base(
            origin: Fragments.Instance,
            unlockLevel: 2,
            name: "Fragments from Somewhere",
            secondaryStats: new SecondaryStats(SR: 2, WS: 2)
        )
        { }
    }
}