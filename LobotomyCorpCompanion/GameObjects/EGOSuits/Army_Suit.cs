namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Army_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Army_Suit _instance = new();

        // Public accessor
        public static Army_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Army_Suit() : base(
            origin: Army.Instance,
            name: "Pink",
            unlockLevel: 4,

            cost: 120,
            maxCount: 1,
            requirements: [5, 0, 0, 0, 5],
            riskLevel: RiskLevel.ALEPH,

            resistances: new Resistances(0.5, 0.3, 0.4, 1.0)
            )
        {
        }
    }
}