namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Current_Gift : EgoGift_Mouth_2
    {
        // Singleton instance
        private static readonly Current_Gift _instance = new Current_Gift();

        // Public accessor
        public static Current_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Current_Gift() : base(
            origin: Current.Instance,
            name: "Ecstasy",
            unlockLevel: 3,
            secondaryStats: new SecondaryStats(SP: 6)
        )
        { }
    }
}