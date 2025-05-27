namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Porccubus_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Porccubus_Suit _instance = new Porccubus_Suit();

        // Public accessor
        public static Porccubus_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Porccubus_Suit() : base(
            origin: Porccubus.Instance,
            name: "Pleasure",
            unlockLevel: 3,

            cost: 30,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            resistances: new Resistances(1.2, 0.8, 0.8, 1.5)
            )
        {
        }
    }
}