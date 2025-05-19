namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Orchestra_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Orchestra_Suit _instance = new Orchestra_Suit();

        // Public accessor
        public static Orchestra_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Orchestra_Suit() : base(
            origin: Orchestra.Instance,
            name: "Da Capo",
            cost: 120,
            maxCount: 1,
            requirements: new int[] { 0, 5, 0, 0, 5 },
            riskLevel: RiskLevel.ALEPH,
            resistances: new Resistances(0.5, 0.2, 0.5, 1.5)
            )
        {
        }
    }
}