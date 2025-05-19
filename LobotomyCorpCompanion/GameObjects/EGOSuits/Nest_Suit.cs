namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Nest_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Nest_Suit _instance = new Nest_Suit();

        // Public accessor
        public static Nest_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nest_Suit() : base(
            origin: Nest.Instance,
            name: "Exuviae",
            cost: 50,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 3 },
            riskLevel: RiskLevel.WAW,
            resistances: new Resistances(0.6, 0.8, 1.2, 1.5)
            )
        {
        }
    }
}