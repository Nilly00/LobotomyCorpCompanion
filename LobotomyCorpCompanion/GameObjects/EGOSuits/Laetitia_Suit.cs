namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Laetitia_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Laetitia_Suit _instance = new Laetitia_Suit();

        // Public accessor
        public static Laetitia_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Laetitia_Suit() : base(
            origin: Laetitia.Instance,
            name: "Laetitia",
            cost: 45,
            maxCount: 1,
            requirements: new int[] { 0, 0, 0, 0, 3 },
            riskLevel: RiskLevel.HE,
            resistances: new Resistances(0.7, 0.7, 0.7, 1.5)
            )
        {
        }
    }
}