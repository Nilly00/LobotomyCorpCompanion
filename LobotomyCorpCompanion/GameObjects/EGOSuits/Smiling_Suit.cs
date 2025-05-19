namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Smiling_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Smiling_Suit _instance = new Smiling_Suit();

        // Public accessor
        public static Smiling_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Smiling_Suit() : base(
            origin: Smiling.Instance,
            name: "Smile",
            cost: 120,
            maxCount: 1,
            requirements: new int[] { 0, 0, 5, 0, 5 },
            riskLevel: RiskLevel.ALEPH,
            resistances: new Resistances(0.5, 0.5, 0.2, 1.0)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Recover HP when passing over an employee's dead body");
        }
    }
}