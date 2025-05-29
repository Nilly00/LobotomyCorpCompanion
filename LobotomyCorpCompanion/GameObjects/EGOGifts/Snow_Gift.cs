namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Snow_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Snow_Gift _instance = new();

        // Public accessor
        public static Snow_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Snow_Gift() : base(
            origin: Snow.Instance,
            name: "Those who know the Cruelty of Winter and the Aroma of Roses",
            unlockLevel: 0,

            slot: Slot.Cheek,
            secondaryStats: new SecondaryStats(HP: 6, SP: 6)
        )
        { }
    }
}