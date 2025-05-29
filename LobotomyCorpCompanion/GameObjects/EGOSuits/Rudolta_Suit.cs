namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Rudolta_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Rudolta_Suit _instance = new();

        // Public accessor
        public static Rudolta_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rudolta_Suit() : base(
            origin: Rudolta.Instance,
            name: "Christmas",
            unlockLevel: 3,

            cost: 40,
            maxCount: 3,
            requirements: [2, 0, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            resistances: new Resistances(0.8, 0.6, 1.3, 1.5)
            )
        {
        }
    }
}