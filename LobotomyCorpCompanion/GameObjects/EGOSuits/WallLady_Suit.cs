namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class WallLady_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly WallLady_Suit _instance = new WallLady_Suit();

        // Public accessor
        public static WallLady_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private WallLady_Suit() : base(
            origin: WallLady.Instance,
            name: "Screaming Wedge",
            cost: 30,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            riskLevel: RiskLevel.TETH,
            resistances: new Resistances(1.2, 0.6, 1.0, 2.0)
            )
        {
        }
    }
}