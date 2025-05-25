namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Wellcheers_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Wellcheers_Suit _instance = new Wellcheers_Suit();

        // Public accessor
        public static Wellcheers_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Wellcheers_Suit() : base(
            origin: Wellcheers.Instance,
            name: "Soda",
            unlockLevel: 2,
            cost: 15,
            maxCount: 5,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            riskLevel: RiskLevel.ZAYIN,
            resistances: new Resistances(0.8, 1.0, 1.0, 2.0)
            )
        {
        }
    }
}