namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Love_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Love_Suit _instance = new Love_Suit();

        // Public accessor
        public static Love_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Love_Suit() : base(
            origin: Love.Instance,
            name: "Adoration",
            unlockLevel: 4,
            cost: 120,
            maxCount: 1,
            requirements: new int[] { 5, 0, 0, 0, 5 },
            riskLevel: RiskLevel.ALEPH,
            resistances: new Resistances(0.3, 0.6, 0.3, 1.0)
            )
        {
        }
    }
}