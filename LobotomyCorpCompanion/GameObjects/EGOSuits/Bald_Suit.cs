namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Bald_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Bald_Suit _instance = new Bald_Suit();

        // Public accessor
        public static Bald_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bald_Suit() : base(
            origin: Bald.Instance,
            name: "Tough",
            cost: 10,
            maxCount: 5,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            riskLevel: RiskLevel.ZAYIN,
            resistances: new Resistances(1.0, 1.0, 0.8, 2.0)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            if (employee.SpecialEffects[0] != "Employee Must be Bald")
            {
                employee.SpecialEffects.Add("Employee Must be Bald");
            }
        }
    }
}