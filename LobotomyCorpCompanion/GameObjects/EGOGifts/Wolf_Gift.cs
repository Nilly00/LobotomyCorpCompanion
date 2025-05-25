namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Wolf_Gift : EgoGift_Face
    {
        // Singleton instance
        private static readonly Wolf_Gift _instance = new Wolf_Gift();

        // Public accessor
        public static Wolf_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Wolf_Gift() : base(
            origin: Wolf.Instance,
            unlockLevel: 3,
            name: "Cobalt Scar",
            secondaryStats: new SecondaryStats(HP: 4, AS: 2, MS: 2)
        )
        { }
    }
}