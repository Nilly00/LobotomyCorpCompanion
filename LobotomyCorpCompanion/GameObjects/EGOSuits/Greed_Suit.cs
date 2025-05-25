namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Greed_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Greed_Suit _instance = new Greed_Suit();

        // Public accessor
        public static Greed_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Greed_Suit() : base(
            origin: Greed.Instance,
            name: "Gold Rush",
            unlockLevel: 3,
            cost: 60,
            maxCount: 1,
            requirements: new int[] { 0, 0, 4, 0, 4 },
            riskLevel: RiskLevel.WAW,
            resistances: new Resistances(0.4, 0.7, 0.8, 2.0)
            )
        {
        }
    }
}