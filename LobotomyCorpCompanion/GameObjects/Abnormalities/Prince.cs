namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Prince : Abnormality
    {
        // Singleton instance
        private static readonly Prince _instance = new Prince();

        // Public accessor
        public static Prince Instance => _instance;

        // Private constructor to prevent external instantiation
        private Prince() : base(
            name: "The Little Prince",
            riskLevel: RiskLevel.WAW,
            weapon: Prince_Weapon.Instance,
            suit: Prince_Suit.Instance,
            gift: Prince_Gift.Instance
            )
        {
        }
    }
}