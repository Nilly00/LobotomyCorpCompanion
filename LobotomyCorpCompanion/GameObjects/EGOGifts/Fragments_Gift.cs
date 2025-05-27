namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Fragments_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Fragments_Gift _instance = new Fragments_Gift();

        // Public accessor
        public static Fragments_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fragments_Gift() : base(
            origin: Fragments.Instance,
            name: "Fragments from Somewhere",
            unlockLevel: 2, 
            
            slot: Slot.Brooch,
            secondaryStats: new SecondaryStats(SR: 2, WS: 2)
        )
        { }
    }
}