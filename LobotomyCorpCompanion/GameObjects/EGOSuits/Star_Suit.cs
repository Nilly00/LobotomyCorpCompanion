namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Star_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Star_Suit _instance = new Star_Suit();

        // Public accessor
        public static Star_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Star_Suit() : base(
            origin: Star.Instance,
            name: "Sound of a Star",
            cost: 150,
            maxCount: 1,
            requirements: new int[] { 0, 5, 5, 0, 5 },
            riskLevel: RiskLevel.ALEPH,
            resistances: new Resistances(0.4, 0.4, 0.4, 1.0)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("+5 SP per second for all Employees in the Room");
        }
    }
}