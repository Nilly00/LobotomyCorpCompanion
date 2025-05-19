namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Despair_Gift : EgoGift_Cheek
    {
        // Singleton instance
        private static readonly Despair_Gift _instance = new Despair_Gift();

        // Public accessor
        public static Despair_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Despair_Gift() : base(
            name: "The Sword Sharpened with Tears",
            secondaryStats: new SecondaryStats(SP: 2, AS: 4, MS: 4)
        )
        { }
    }
}