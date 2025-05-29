namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Crumbling_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Crumbling_Suit _instance = new();

        // Public accessor
        public static Crumbling_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Crumbling_Suit() : base(
            origin: Crumbling.Instance,
            name: "Life for a Daredevil",
            unlockLevel: 2,

            cost: 30,
            maxCount: 1,
            requirements: [0, 2, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(0.6, 0.9, 0.9, 2.0)
            )
        {
        }
    }
}