namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Beauty_Gift : EgoGift_Hat
    {
        // Singleton instance
        private static readonly Beauty_Gift _instance = new Beauty_Gift();

        // Public accessor
        public static Beauty_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Beauty_Gift() : base(
            origin: Beauty.Instance,
            name: "Horn",
            unlockLevel: 2,
            secondaryStats: new SecondaryStats(HP: 2, SP: 2)
        )
        { }
    }
}