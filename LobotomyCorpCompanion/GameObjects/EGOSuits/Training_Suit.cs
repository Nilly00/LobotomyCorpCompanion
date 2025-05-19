namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Training_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Training_Suit _instance = new Training_Suit();

        // Public accessor
        public static Training_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Training_Suit() : base(
            origin: Training.Instance,
            name: "Standard Training E.G.O",
            cost: 1,
            maxCount: 5,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            riskLevel: RiskLevel.TETH,
            resistances: new Resistances(0.5, 1.0, 1.5, 2.0)
            )
        {
        }
    }
}