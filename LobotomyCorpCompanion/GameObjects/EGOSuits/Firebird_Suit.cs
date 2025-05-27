namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Firebird_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Firebird_Suit _instance = new Firebird_Suit();

        // Public accessor
        public static Firebird_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Firebird_Suit() : base(
            origin: Firebird.Instance,
            name: "Feather of Honor",
            unlockLevel: 3,

            cost: 50,
            maxCount: 2,
            requirements: [3, 0, 0, 0, 3],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.6, 0.6, 1.3, 2.0)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Will die instantly if trying to perform work with Snow Queen");
        }
    }
}