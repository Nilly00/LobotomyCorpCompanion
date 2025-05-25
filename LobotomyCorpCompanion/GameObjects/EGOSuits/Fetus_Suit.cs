namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Fetus_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Fetus_Suit _instance = new Fetus_Suit();

        // Public accessor
        public static Fetus_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fetus_Suit() : base(
            origin: Fetus.Instance,
            name: "Syrinx",
            unlockLevel: 4,
            cost: 45,
            maxCount: 1,
            requirements: new int[] { 0, 0, 3, 0, 0 },
            riskLevel: RiskLevel.HE,
            resistances: new Resistances(1.2, 0.5, 0.8, 1.5)
            )
        {
        }
    }
}