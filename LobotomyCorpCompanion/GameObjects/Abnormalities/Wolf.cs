namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Wolf : Abnormality
    {
        // Singleton instance
        private static readonly Wolf _instance = new();

        // Public accessor
        public static Wolf Instance => _instance;

        // Private constructor to prevent external instantiation
        private Wolf() : base(
            name: "The Big and Will be Bad Wolf",
            riskLevel: RiskLevel.WAW,
            weapon: Wolf_Weapon.Instance,
            suit: Wolf_Suit.Instance,
            gift: Wolf_Gift.Instance
            )
        {
        }
    }
}