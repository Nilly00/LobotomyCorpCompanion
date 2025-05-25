namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Parasite_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Parasite_Suit _instance = new Parasite_Suit();

        // Public accessor
        public static Parasite_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Parasite_Suit() : base(
            origin: Parasite.Instance,
            name: "Hypocrisy",
            unlockLevel: 4,
            cost: 60,
            maxCount: 1,
            requirements: new int[] { 0, 3, 0, 0, 0 },
            riskLevel: RiskLevel.WAW,
            resistances: new Resistances(0.7, 0.5, 1.5, 1.5)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("All Employees in the same room heal 2.5 SP every 2.5 s");
        }
    }
}
