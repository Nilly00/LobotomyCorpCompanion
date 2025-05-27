namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Shoes_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Shoes_Suit _instance = new Shoes_Suit();

        // Public accessor
        public static Shoes_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Shoes_Suit() : base(
            origin: Shoes.Instance,
            name: "Sanguine Desire",
            unlockLevel: 3,

            cost: 50,
            maxCount: 1,
            requirements: [0, 0, 3, 0, 0],
            riskLevel: RiskLevel.HE,

            resistances: new Resistances(0.5, 1.2, 0.8, 1.5)
            )
        {
        }
    }
}