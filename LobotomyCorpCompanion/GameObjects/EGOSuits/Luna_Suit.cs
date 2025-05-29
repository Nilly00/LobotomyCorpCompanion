namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Luna_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Luna_Suit _instance = new();

        // Public accessor
        public static Luna_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Luna_Suit() : base(
            origin: Luna.Instance,
            name: "Moonlight",
            unlockLevel: 4,

            cost: 60,
            maxCount: 1,
            requirements: [0, 0, 3, 0, 0],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.8, 0.4, 0.7, 2.0)
            )
        {
        }
    }
}