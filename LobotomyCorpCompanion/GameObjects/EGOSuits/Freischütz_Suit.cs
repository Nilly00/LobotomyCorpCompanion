namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Freischütz_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Freischütz_Suit _instance = new Freischütz_Suit();

        // Public accessor
        public static Freischütz_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Freischütz_Suit() : base(
            origin: Freischütz.Instance,
            name: "Magic Bullet",
            unlockLevel: 4,

            cost: 45,
            maxCount: 1,
            requirements: [3, 0, 0, 3, 0],
            riskLevel: RiskLevel.HE,

            resistances: new Resistances(0.7, 0.7, 0.7, 1.5)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            if (SameWeapon(employee))
            {
                employee.permanentBonuses.damageFlat += 3;
            }
        }
    }
}