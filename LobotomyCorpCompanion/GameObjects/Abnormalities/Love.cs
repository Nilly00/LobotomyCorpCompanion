namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Love : Abnormality
    {
        // Singleton instance
        private static readonly Love _instance = new Love();

        // Public accessor
        public static Love Instance => _instance;

        // Private constructor to prevent external instantiation
        private Love() : base(
            name: "Melting Love",
            riskLevel: RiskLevel.ALEPH,
            weapon: Love_Weapon.Instance,
            suit: Love_Suit.Instance,
            gift: Love_Gift.Instance
            )
        {
        }
    }
}
