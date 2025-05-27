namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class OldLady_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly OldLady_Suit _instance = new OldLady_Suit();

        // Public accessor
        public static OldLady_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private OldLady_Suit() : base(
            origin: OldLady.Instance,
            name: "Solitude",
            unlockLevel: 2,

            cost: 20,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(1.5, 0.8, 0.8, 2.0)
            )
        {
        }
    }
}