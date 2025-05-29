namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Heaven : Abnormality
    {
        // Singleton instance
        private static readonly Heaven _instance = new();

        // Public accessor
        public static Heaven Instance => _instance;

        // Private constructor to prevent external instantiation
        private Heaven() : base(
            name: "The Burrowing Heaven",
            riskLevel: RiskLevel.WAW,
            weapon: Heaven_Weapon.Instance,
            suit: Heaven_Suit.Instance,
            gift: Heaven_Gift.Instance
            )
        {
        }
    }
}
