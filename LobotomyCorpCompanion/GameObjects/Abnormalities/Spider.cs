namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Spider : Abnormality
    {
        // Singleton instance
        private static readonly Spider _instance = new();

        // Public accessor
        public static Spider Instance => _instance;

        // Private constructor to prevent external instantiation
        private Spider() : base(
            name: "Spider Bud",
            riskLevel: RiskLevel.TETH,
            weapon: Spider_Weapon.Instance,
            suit: Spider_Suit.Instance,
            gift: Spider_Gift.Instance
            )
        {
        }
    }
}