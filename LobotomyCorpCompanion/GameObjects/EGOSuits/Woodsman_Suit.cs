namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Woodsman_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Woodsman_Suit _instance = new Woodsman_Suit();

        // Public accessor
        public static Woodsman_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Woodsman_Suit() : base(
            origin: Woodsman.Instance,
            name: "Logging",
            cost: 30,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            riskLevel: RiskLevel.HE,
            resistances: new Resistances(0.8, 1.2, 0.8, 1.5)
            )
        {
        }
        internal override void Effect(Employee employee)
        {
        }
    }
}