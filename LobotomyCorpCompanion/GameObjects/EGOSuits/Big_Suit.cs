namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Big_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Big_Suit _instance = new Big_Suit();

        // Public accessor
        public static Big_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Big_Suit() : base(
            origin: Big.Instance,
            unlockLevel: 4,
            name: "Lamp",

            cost: 60,
            maxCount: 1,
            requirements: [0, 0, 3, 3, 4],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.8, 0.7, 0.4, 1.5)
            )
        {
        }
    }
}