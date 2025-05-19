namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Snow_Gift : EgoGift_Cheek
    {
        // Singleton instance
        private static readonly Snow_Gift _instance = new Snow_Gift();

        // Public accessor
        public static Snow_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Snow_Gift() : base(
            name: "Those who know the Cruelty of Winter and the Aroma of Roses",
            secondaryStats: new SecondaryStats(HP: 6, SP: 6)
        )
        { }
    }
}