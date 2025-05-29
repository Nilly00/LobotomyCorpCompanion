namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Judgement : Abnormality
    {
        // Singleton instance
        private static readonly Judgement _instance = new();

        // Public accessor
        public static Judgement Instance => _instance;

        // Private constructor to prevent external instantiation
        private Judgement() : base(
            name: "Judgement Bird",
            riskLevel: RiskLevel.WAW,
            weapon: Judgement_Weapon.Instance,
            suit: Judgement_Suit.Instance,
            gift: Judgement_Gift.Instance
            )
        {
        }
    }
}
