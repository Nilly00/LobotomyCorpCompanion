namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Bloodbath_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Bloodbath_Suit _instance = new Bloodbath_Suit();

        // Public accessor
        public static Bloodbath_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bloodbath_Suit() : base(
            origin: Bloodbath.Instance,
            unlockLevel: 3,
            name: "Wrist Cutter",
            cost: 25,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            riskLevel: RiskLevel.TETH,
            resistances: new Resistances(1.0, 0.6, 1.2, 2.0)
            )
        {
        }
    }
}