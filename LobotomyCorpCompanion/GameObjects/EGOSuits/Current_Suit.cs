namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Current_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Current_Suit _instance = new Current_Suit();

        // Public accessor
        public static Current_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Current_Suit() : base(
            origin: Current.Instance,
            name: "Ecstasy",
            unlockLevel: 3,

            cost: 40,
            maxCount: 3,
            requirements: [0, 0, 2, 0, 2],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.8, 0.8, 0.8, 1.5)
            )
        {
        }
    }
}