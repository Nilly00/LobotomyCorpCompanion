namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Despair_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Despair_Suit _instance = new Despair_Suit();

        // Public accessor
        public static Despair_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Despair_Suit() : base(
            origin: Despair.Instance,
            name: "The Sword Sharpened with Tears",
            unlockLevel: 4,

            cost: 60,
            maxCount: 1,
            requirements: [0, 0, 0, 4, 0],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.8, 0.8, 0.8, 0.8)
            )
        {
        }
    }
}