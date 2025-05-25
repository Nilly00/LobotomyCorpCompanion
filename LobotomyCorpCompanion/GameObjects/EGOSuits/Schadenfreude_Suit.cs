namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Schadenfreude_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Schadenfreude_Suit _instance = new Schadenfreude_Suit();

        // Public accessor
        public static Schadenfreude_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Schadenfreude_Suit() : base(
            origin: Schadenfreude.Instance,
            name: "Gaze",
            unlockLevel: 3,
            cost: 30,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            riskLevel: RiskLevel.HE,
            resistances: new Resistances(1.0, 0.8, 1.0, 1.5)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("JUSTICE and Defense boosted while on screen");
            employee.conditionalBonuses.primaryStats.Justice += 10;
            //todo figure out how to do this nonesense
        }
    }
}