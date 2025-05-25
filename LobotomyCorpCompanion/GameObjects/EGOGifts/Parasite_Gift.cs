namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Parasite_Gift : EgoGift_Helmet
    {
        // Singleton instance
        private static readonly Parasite_Gift _instance = new Parasite_Gift();

        // Public accessor
        public static Parasite_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Parasite_Gift() : base(
            origin: Parasite.Instance,
            name: "Hypocrisy",
            unlockLevel: 3,
            secondaryStats: new SecondaryStats(HP:3, SP:3)
        )
        { }
    }
}