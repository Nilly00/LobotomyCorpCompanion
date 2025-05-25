namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Shy : Abnormality
    {
        // Singleton instance
        private static readonly Shy _instance = new Shy();

        // Public accessor
        public static Shy Instance => _instance;

        // Private constructor to prevent external instantiation
        private Shy() : base(
            name: "Today's Shy look",
            riskLevel: RiskLevel.TETH,
            weapon: Shy_Weapon.Instance,
            suit: Shy_Suit.Instance,
            gift: Shy_Gift.Instance
            )
        {
        }
    }
}