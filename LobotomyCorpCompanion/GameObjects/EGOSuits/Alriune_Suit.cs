namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Alriune_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Alriune_Suit _instance = new Alriune_Suit();

        // Public accessor
        public static Alriune_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Alriune_Suit() : base(
            origin: Alriune.Instance,
            name: "Faint Aroma",
            unlockLevel: 3,

            cost: 50,
            maxCount: 2,
            requirements: [0, 3, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(1.2, 0.6, 0.8, 1.5)
            )
        {
        }
    }
}
