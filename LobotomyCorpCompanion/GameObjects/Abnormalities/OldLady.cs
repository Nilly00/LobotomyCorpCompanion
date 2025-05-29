namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class OldLady : Abnormality
    {
        // Singleton instance
        private static readonly OldLady _instance = new();

        // Public accessor
        public static OldLady Instance => _instance;

        // Private constructor to prevent external instantiation
        private OldLady() : base(
            name: "Old Lady",
            riskLevel: RiskLevel.TETH,
            weapon: OldLady_Weapon.Instance,
            suit: OldLady_Suit.Instance,
            gift: OldLady_Gift.Instance
            )
        {
        }
    }
}
