namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Dream_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Dream_Suit _instance = new();

        // Public accessor
        public static Dream_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Dream_Suit() : base(
            origin: Dream.Instance,
            name: "Engulfing Dream",
            unlockLevel: 3,

            cost: 25,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(1.2, 0.8, 0.7, 2.0)
            )
        {
        }
    }
}