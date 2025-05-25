namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Snow_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Snow_Suit _instance = new Snow_Suit();

        // Public accessor
        public static Snow_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Snow_Suit() : base(
            origin: Snow.Instance,
            name: "Frost Splinter",
            unlockLevel: 3,
            cost: 35,
            maxCount: 2,
            requirements: new int[] { 2, 0, 0, 0, 0 },
            riskLevel: RiskLevel.HE,
            resistances: new Resistances(1.3, 0.6, 0.8, 1.5)
            )
        {
        }
    }
}