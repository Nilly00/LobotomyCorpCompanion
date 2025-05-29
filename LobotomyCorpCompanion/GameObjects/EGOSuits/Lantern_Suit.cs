namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Lantern_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Lantern_Suit _instance = new();

        // Public accessor
        public static Lantern_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Lantern_Suit() : base(
            origin: Lantern.Instance,
            name: "Lantern",
            unlockLevel: 3,

            cost: 30,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(0.8, 0.7, 1.2, 2.0)
            )
        {
        }
    }
}