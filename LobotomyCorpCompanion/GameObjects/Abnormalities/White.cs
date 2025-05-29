namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class White : Abnormality
    {
        // Singleton instance
        private static readonly White _instance = new();

        // Public accessor
        public static White Instance => _instance;

        // Private constructor to prevent external instantiation
        private White() : base(
            name: "White Night",
            riskLevel: RiskLevel.ALEPH,
            weapon: White_Weapon.Instance,
            suit: White_Suit.Instance,
            gift: White_Gift.Instance
            )
        {
        }
    }
}