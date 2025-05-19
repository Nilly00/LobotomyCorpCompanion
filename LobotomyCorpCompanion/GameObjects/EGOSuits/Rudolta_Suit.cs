namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Rudolta_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Rudolta_Suit _instance = new Rudolta_Suit();

        // Public accessor
        public static Rudolta_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rudolta_Suit() : base(
            origin: Rudolta.Instance,
            name: "Christmas",
            cost: 40,
            maxCount: 3,
            requirements: new int[] { 2, 0, 0, 0, 0 },
            riskLevel: RiskLevel.HE,
            resistances: new Resistances(0.8, 0.6, 1.3, 1.5)
            )
        {
        }
    }
}