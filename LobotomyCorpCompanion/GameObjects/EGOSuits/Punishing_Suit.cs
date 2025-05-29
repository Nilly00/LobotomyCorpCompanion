namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Punishing_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Punishing_Suit _instance = new();

        // Public accessor
        public static Punishing_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Punishing_Suit() : base(
            origin: Punishing.Instance,
            name: "Beak",
            unlockLevel: 3,

            cost: 25,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(0.7, 0.8, 1.2, 2.0)
            )
        {
        }
    }
}