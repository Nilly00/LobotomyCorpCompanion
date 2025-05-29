namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Army : Abnormality
    {
        // Singleton instance
        private static readonly Army _instance = new();

        // Public accessor
        public static Army Instance => _instance;

        // Private constructor to prevent external instantiation
        private Army() : base(
            name: "Army in Black",
            riskLevel: RiskLevel.ALEPH,
            weapon: Army_Weapon.Instance,
            suit: Army_Suit.Instance,
            gift: Army_Gift.Instance
            )
        {
        }
    }
}
