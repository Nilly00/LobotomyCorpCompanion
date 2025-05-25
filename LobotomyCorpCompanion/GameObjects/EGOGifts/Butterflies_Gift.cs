namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Butterflies_Gift : EgoGift_Right_Back
    {
        // Singleton instance
        private static readonly Butterflies_Gift _instance = new Butterflies_Gift();

        // Public accessor
        public static Butterflies_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Butterflies_Gift() : base(
            origin: Butterflies.Instance,
            name: "Solemn Lament",
            unlockLevel: 3,
            secondaryStats: new SecondaryStats(1, 1, 1, 1, 1, 1)
        )
        { }
    }
}