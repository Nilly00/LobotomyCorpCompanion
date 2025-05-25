namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Current : Abnormality
    {
        // Singleton instance
        private static readonly Current _instance = new Current();

        // Public accessor
        public static Current Instance => _instance;

        // Private constructor to prevent external instantiation
        private Current() : base(
            name: "The Dreaming Current",
            riskLevel: RiskLevel.WAW,
            weapon: Current_Weapon.Instance,
            suit: Current_Suit.Instance,
            gift: Current_Gift.Instance
            )
        {
        }
    }
}
