namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Dream : Abnormality
    {
        // Singleton instance
        private static readonly Dream _instance = new();

        // Public accessor
        public static Dream Instance => _instance;

        // Private constructor to prevent external instantiation
        private Dream() : base(
            name: "Void Dream",
            riskLevel: RiskLevel.TETH,
            weapon: Dream_Weapon.Instance,
            suit: Dream_Suit.Instance,
            gift: Dream_Gift.Instance
            )
        {
        }
    }
}
