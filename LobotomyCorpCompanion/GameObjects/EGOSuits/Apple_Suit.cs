namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Apple_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Apple_Suit _instance = new();

        // Public accessor
        public static Apple_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apple_Suit() : base(
            origin: Apple.Instance,
            name: "Green Stem",
            unlockLevel: 3,

            cost: 50,
            maxCount: 2,
            requirements: [0, 3, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.8, 1.2, 0.6, 1.5)
            )
        {
        }
    }
}