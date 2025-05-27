namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Fragments_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Fragments_Suit _instance = new Fragments_Suit();

        // Public accessor
        public static Fragments_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fragments_Suit() : base(
            origin: Fragments.Instance,
            name: "Fragments from Somewhere",
            unlockLevel: 3,

            cost: 25,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(1.0, 1.2, 0.6, 2.0)
            )
        {
        }
    }
}