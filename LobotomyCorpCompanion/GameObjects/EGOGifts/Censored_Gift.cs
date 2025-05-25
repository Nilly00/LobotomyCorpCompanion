namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Censored_Gift : EgoGift_Eye
    {
        // Singleton instance
        private static readonly Censored_Gift _instance = new Censored_Gift();

        // Public accessor
        public static Censored_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Censored_Gift() : base(
            origin: Censored.Instance,
            name: "CENSORED",
            unlockLevel: 4,
            secondaryStats: new SecondaryStats(SP: 10)
        )
        { }
    }
}