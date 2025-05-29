namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Swan : Abnormality
    {
        // Singleton instance
        private static readonly Swan _instance = new();

        // Public accessor
        public static Swan Instance => _instance;

        // Private constructor to prevent external instantiation
        private Swan() : base(
            name: "Dream of a Black Swan",
            riskLevel: RiskLevel.WAW,
            weapon: Swan_Weapon.Instance,
            suit: Swan_Suit.Instance,
            gift: Swan_Gift.Instance
            )
        {
        }
    }
}