namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Monk_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Monk_Suit _instance = new();

        // Public accessor
        public static Monk_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Monk_Suit() : base(
            origin: Monk.Instance,
            name: "Amita",
            unlockLevel: 4,

            cost: 50,
            maxCount: 2,
            requirements: [0, 2, 2, 0, 0],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.5, 1.3, 0.7, 1.5)
            )
        {
        }
    }
}