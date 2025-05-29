namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Helper : Abnormality
    {
        // Singleton instance
        private static readonly Helper _instance = new();

        // Public accessor
        public static Helper Instance => _instance;

        // Private constructor to prevent external instantiation
        private Helper() : base(
            name: "All-Around Helper",
            riskLevel: RiskLevel.HE,
            weapon: Helper_Weapon.Instance,
            suit: Helper_Suit.Instance,
            gift: Helper_Gift.Instance
            )
        {
        }
    }
}
