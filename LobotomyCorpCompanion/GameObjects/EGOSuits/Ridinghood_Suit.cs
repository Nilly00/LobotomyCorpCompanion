namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Ridinghood_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Ridinghood_Suit _instance = new();

        // Public accessor
        public static Ridinghood_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Ridinghood_Suit() : base(
            origin: Ridinghood.Instance,
            name: "Crimson Scar",
            unlockLevel: 4,

            cost: 60,
            maxCount: 1,
            requirements: [3, 0, 0, 3, 4],
            riskLevel: RiskLevel.WAW,

            resistances: new Resistances(0.6, 0.6, 0.6, 1.5)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Movement Speed +30% when suppressing");
            employee.ConditionalBonuses.MovespeedPercent *= 1.3;
        }
    }
}