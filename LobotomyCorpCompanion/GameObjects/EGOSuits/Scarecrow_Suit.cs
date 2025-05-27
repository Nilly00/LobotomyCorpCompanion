namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Scarecrow_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Scarecrow_Suit _instance = new Scarecrow_Suit();

        // Public accessor
        public static Scarecrow_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Scarecrow_Suit() : base(
            origin: Scarecrow.Instance,
            name: "Harvest",
            unlockLevel: 3,

            cost: 35,
            maxCount: 2,
            requirements: [0, 2, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            resistances: new Resistances(0.6, 0.8, 1.3, 1.5)
            )
        {
        }
    }
}