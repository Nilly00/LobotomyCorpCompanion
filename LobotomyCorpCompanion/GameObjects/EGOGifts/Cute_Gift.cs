namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Cute_Gift : EgoGift_Hat
    {
        // Singleton instance
        private static readonly Cute_Gift _instance = new Cute_Gift();

        // Public accessor
        public static Cute_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Cute_Gift() : base(
            origin: Cute.Instance,
            unlockLevel: 2,
            name: "SO CUTE!!!",
            secondaryStats: new SecondaryStats(HP: 4, SR: 2, WS: 2)
        )
        { }
    }
}