namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Punishing_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Punishing_Gift _instance = new Punishing_Gift();

        // Public accessor
        public static Punishing_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Punishing_Gift() : base(
            origin: Punishing.Instance,
            name: "Beak",
            unlockLevel: 2,

            slot: Slot.Neckwear,
            secondaryStats: new SecondaryStats(AS: 2, MS: 2)
        )
        { }
    }
}