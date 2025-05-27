namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Scorched_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Scorched_Suit _instance = new Scorched_Suit();

        // Public accessor
        public static Scorched_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Scorched_Suit() : base(
            origin: Scorched.Instance,
            name: "Fourth Match Flame",
            unlockLevel: 3,

            cost: 25,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(0.6, 1.0, 1.2, 2.0)
            )
        {
        }
    }
}