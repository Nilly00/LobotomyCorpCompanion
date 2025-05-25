namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Bald_Gift : EgoGift_Eye
    {
        // Singleton instance
        private static readonly Bald_Gift _instance = new Bald_Gift();

        // Public accessor
        public static Bald_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bald_Gift() : base(
            origin: Bald.Instance,
            name: "Tough",
            unlockLevel: 3,
            secondaryStats: new SecondaryStats(AS: 2, MS: 2)
        )
        { }
    }
}