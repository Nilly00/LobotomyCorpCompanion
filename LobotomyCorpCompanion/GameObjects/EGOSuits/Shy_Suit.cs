namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Shy_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Shy_Suit _instance = new Shy_Suit();

        // Public accessor
        public static Shy_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Shy_Suit() : base(
            origin: Shy.Instance,
            name: "Today's Expression",
            unlockLevel: 4,
            cost: 30,
            maxCount: 1,
            requirements: new int[] { 2, 0, 0, 0, 0 },
            riskLevel: RiskLevel.TETH,
            resistances: new Resistances(0.7, 0.6, 1.5, 2.0)
            )
        {
        }
    }
}