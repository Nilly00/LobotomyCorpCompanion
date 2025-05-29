namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Big : Abnormality
    {
        // Singleton instance
        private static readonly Big _instance = new();

        // Public accessor
        public static Big Instance => _instance;

        // Private constructor to prevent external instantiation
        private Big() : base(
            name: "Big Bird",
            riskLevel: RiskLevel.WAW,
            weapon: Big_Weapon.Instance,
            suit: Big_Suit.Instance,
            gift: Big_Gift.Instance
            )
        {
        }
    }
}
