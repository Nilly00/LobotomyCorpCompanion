namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Beauty_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Beauty_Suit _instance = new Beauty_Suit();

        // Public accessor
        public static Beauty_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Beauty_Suit() : base(
            origin: Beauty.Instance,
            name: "Horn",
            cost: 30,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            riskLevel: RiskLevel.TETH,
            resistances: new Resistances(0.8, 0.8, 1.5, 2.0)
            )
        {
        }
    }
}