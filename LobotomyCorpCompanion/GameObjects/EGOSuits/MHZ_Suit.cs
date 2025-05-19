namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class MHZ_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly MHZ_Suit _instance = new MHZ_Suit();

        // Public accessor
        public static MHZ_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private MHZ_Suit() : base(
            origin: MHZ.Instance,
            name: "Noise",
            cost: 30,
            maxCount: 1,
            requirements: new int[] { 0, 2, 0, 0, 0 },
            riskLevel: RiskLevel.TETH,
            resistances: new Resistances(1.2, 0.7, 0.6, 2.0)
            )
        {
        }
    }
}