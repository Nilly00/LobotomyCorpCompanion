namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class White_Gift : EgoGift_Left_Back
    {
        // Singleton instance
        private static readonly White_Gift _instance = new White_Gift();

        // Public accessor
        public static White_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private White_Gift() : base(
            origin: White.Instance,
            unlockLevel: 0,
            name: "",
            secondaryStats: new SecondaryStats(HP: 10, SP: 10, AS: 10, MS: 10)
        )
        { }
    }
}