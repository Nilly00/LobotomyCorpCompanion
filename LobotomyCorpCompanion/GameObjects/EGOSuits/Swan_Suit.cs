namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Swan_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Swan_Suit _instance = new Swan_Suit();

        // Public accessor
        public static Swan_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Swan_Suit() : base(
            origin: Swan.Instance,
            name: "Black Swan",
            unlockLevel: 3,

            cost: 50,
            maxCount: 2,
            requirements: [0, 0, 3, 0, 0],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.6, 1.2, 0.8, 1.5)
            )
        {
        }
    }
}