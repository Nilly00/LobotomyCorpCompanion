namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Rabbit_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Rabbit_Suit _instance = new Rabbit_Suit();

        // Public accessor
        public static Rabbit_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rabbit_Suit() : base(
            origin: Rabbit.Instance,
            name: "Standard Training E.G.O",
            unlockLevel: 4,
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