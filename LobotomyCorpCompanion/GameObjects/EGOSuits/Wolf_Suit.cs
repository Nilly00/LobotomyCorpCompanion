namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Wolf_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Wolf_Suit _instance = new();

        // Public accessor
        public static Wolf_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Wolf_Suit() : base(
            origin: Wolf.Instance,
            name: "Cobalt Scar",
            unlockLevel: 4,

            cost: 60,
            maxCount: 1,
            requirements: [4, 0, 0, 0, 4],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.4, 0.8, 0.7, 2.0)
            )
        {
        }
    }
}