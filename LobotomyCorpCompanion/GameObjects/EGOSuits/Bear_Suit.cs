namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Bear_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Bear_Suit _instance = new Bear_Suit();

        // Public accessor
        public static Bear_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bear_Suit() : base(
            origin: Bear.Instance,
            unlockLevel: 2,
            name: "Bear Paws",
            cost: 30,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 2 },
            riskLevel: RiskLevel.HE,
            resistances: new Resistances(0.8, 1.0, 1.0, 1.5)
            )
        {
        }
    }
}