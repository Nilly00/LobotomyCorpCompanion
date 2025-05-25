namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Nothing_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Nothing_Suit _instance = new Nothing_Suit();

        // Public accessor
        public static Nothing_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nothing_Suit() : base(
            origin: Nothing.Instance,
            name: "Mimicry",
            unlockLevel: 4,
            cost: 120,
            maxCount: 1,
            requirements: new int[] { 5, 0, 0, 0, 5 },
            riskLevel: RiskLevel.ALEPH,
            resistances: new Resistances(0.2, 0.2, 0.5, 1.0)
            )
        {
        }
    }
}