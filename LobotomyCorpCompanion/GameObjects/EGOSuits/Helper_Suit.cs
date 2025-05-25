namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Helper_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Helper_Suit _instance = new Helper_Suit();

        // Public accessor
        public static Helper_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Helper_Suit() : base(
            origin: Helper.Instance,
            name: "Grinder Mk4",
            unlockLevel: 3,
            cost: 35,
            maxCount: 3,
            requirements: new int[] { 0, 2, 0, 0, 0 },
            riskLevel: RiskLevel.HE,
            resistances: new Resistances(0.6, 1.3, 0.9, 1.5)
            )
        {
        }
    }
}