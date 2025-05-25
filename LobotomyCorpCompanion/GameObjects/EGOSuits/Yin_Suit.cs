namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Yin_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Yin_Suit _instance = new Yin_Suit();

        // Public accessor
        public static Yin_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Yin_Suit() : base(
            origin: Yin.Instance,
            name: "Discord",
            unlockLevel: 3,
            cost: 50,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 3, 0 },
            riskLevel: RiskLevel.WAW,
            resistances: new Resistances(1.2, 0.8, 0.6, 0.5)
            )
        {
        }
        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("8% chance to heal as much as damage taken");
        }
    }
}