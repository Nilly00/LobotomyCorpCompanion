namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Hatred_Gift : EgoGift_Hat
    {
        // Singleton instance
        private static readonly Hatred_Gift _instance = new Hatred_Gift();

        // Public accessor
        public static Hatred_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Hatred_Gift() : base(
            origin: Hatred.Instance,
            name: "In the Name of Love and Hate",
            unlockLevel: 3,
            secondaryStats: new SecondaryStats(SR: 2, WS: 2, AS: 4, MS: 4)
        )
        { }
    }
}