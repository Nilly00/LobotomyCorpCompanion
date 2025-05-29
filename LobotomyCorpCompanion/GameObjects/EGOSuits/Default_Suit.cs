namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Default_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Default_Suit _instance = new();

        // Public accessor
        public static Default_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Default_Suit() : base(
            origin: Default.Instance,
            name: "Standard Uniform",
            unlockLevel: 0,

            cost: -1,
            maxCount: -1,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.ZAYIN,

            resistances: new Resistances(1.0, 1.0, 1.5, 2.0)
            )
        {
        }
    }
}