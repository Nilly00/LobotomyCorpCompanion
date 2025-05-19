namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Galaxy_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Galaxy_Suit _instance = new Galaxy_Suit();

        // Public accessor
        public static Galaxy_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Galaxy_Suit() : base(
            origin: Galaxy.Instance,
            name: "Our Galaxy",
            cost: 30,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            riskLevel: RiskLevel.HE,
            resistances: new Resistances(0.8, 0.8, 1.2, 1.5)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Pebble Healing increased");
        }
    }
}