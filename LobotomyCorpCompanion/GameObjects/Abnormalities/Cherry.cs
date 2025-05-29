namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Cherry : Abnormality
    {
        // Singleton instance
        private static readonly Cherry _instance = new();

        // Public accessor
        public static Cherry Instance => _instance;

        // Private constructor to prevent external instantiation
        private Cherry() : base(
            name: "Grave of Cherry Blossoms",
            riskLevel: RiskLevel.TETH,
            weapon: Cherry_Weapon.Instance,
            suit: Cherry_Suit.Instance,
            gift: Cherry_Gift.Instance
            )
        {
        }
    }
}
