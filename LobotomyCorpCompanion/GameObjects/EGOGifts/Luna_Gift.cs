namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Luna_Gift : EgoGift_Brooch
    {
        // Singleton instance
        private static readonly Luna_Gift _instance = new Luna_Gift();

        // Public accessor
        public static Luna_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Luna_Gift() : base(
            origin: Luna.Instance,
            name: "Moonlight",
            unlockLevel: 3,
            secondaryStats: new SecondaryStats(1, 1, 1, 1, 1, 1)
        )
        { }
    }
}