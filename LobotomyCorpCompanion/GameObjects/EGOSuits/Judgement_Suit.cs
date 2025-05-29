namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Judgement_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Judgement_Suit _instance = new();

        // Public accessor
        public static Judgement_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Judgement_Suit() : base(
            origin: Judgement.Instance,
            name: "Justitia",
            unlockLevel: 4,

            cost: 120,
            maxCount: 1,
            requirements: [0, 0, 0, 5, 5],
            riskLevel: RiskLevel.ALEPH,

            resistances: new Resistances(0.5, 0.5, 0.5, 0.5)
            )
        {
        }
    }
}