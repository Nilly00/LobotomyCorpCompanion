namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class White_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly White_Suit _instance = new White_Suit();

        // Public accessor
        public static White_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private White_Suit() : base(
            origin: White.Instance,
            name: "Paradise Lost",
            unlockLevel: 0,
            cost: -1,
            maxCount: 1,
            requirements: new int[] { 5, 5, 5, 5, 5 },
            riskLevel: RiskLevel.ALEPH,
            resistances: new Resistances(0.5, 0.5, 0.5, 0.3)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            //todo implement ressitance altering effect
            if (origin.SameGift(employee))
            {
                employee.SpecialEffects.Add("Immune to damages that are 10 or lower during Supression.");
            }
            else
            {
                employee.SpecialEffects.Add("Immune to damages that are 5 or lower during Supression.");
            }
        }
    }
}