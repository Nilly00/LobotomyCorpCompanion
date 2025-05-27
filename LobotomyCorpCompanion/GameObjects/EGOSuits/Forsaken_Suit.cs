namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Forsaken_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Forsaken_Suit _instance = new Forsaken_Suit();

        // Public accessor
        public static Forsaken_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Forsaken_Suit() : base(
            origin: Forsaken.Instance,
            name: "Regret",
            unlockLevel: 3,

            cost: 25,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(0.7, 1.2, 0.8, 2.0)
            )
        {
        }
    }
}