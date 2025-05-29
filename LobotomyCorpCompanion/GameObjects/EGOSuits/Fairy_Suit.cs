namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Fairy_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Fairy_Suit _instance = new();

        // Public accessor
        public static Fairy_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fairy_Suit() : base(
            origin: Fairy.Instance,
            name: "Wingbeat",
            unlockLevel: 2,

            cost: 10,
            maxCount: 5,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.ZAYIN,

            resistances: new Resistances(0.8, 0.8, 1.0, 2.0)
            )
        {
        }
    }
}