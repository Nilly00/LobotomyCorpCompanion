namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Butterflies_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Butterflies_Suit _instance = new Butterflies_Suit();

        // Public accessor
        public static Butterflies_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Butterflies_Suit() : base(
            origin: Butterflies.Instance,
            name: "Solemn Lament",
            unlockLevel: 4,
            cost: 45,
            maxCount: 1,
            requirements: new int[] { 0, 0, 0, 3, 0 },
            riskLevel: RiskLevel.HE,
            resistances: new Resistances(1.2, 0.8, 0.5, 2.0)
            )
        {
        }
    }
}