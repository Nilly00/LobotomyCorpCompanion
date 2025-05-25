namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Forsaken_Gift : EgoGift_Mouth_1
    {
        // Singleton instance
        private static readonly Forsaken_Gift _instance = new Forsaken_Gift();

        // Public accessor
        public static Forsaken_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Forsaken_Gift() : base(
            origin: Forsaken.Instance,
            unlockLevel: 2,
            name: "Regret",
            secondaryStats: new SecondaryStats(HP: 2, SP: 2)
        )
        { }
    }
}