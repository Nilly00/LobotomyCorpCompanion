namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Beauty : Abnormality
    {
        // Singleton instance
        private static readonly Beauty _instance = new();

        // Public accessor
        public static Beauty Instance => _instance;

        // Private constructor to prevent external instantiation
        private Beauty() : base(
            name: "Beauty and the Beast",
            riskLevel: RiskLevel.HE,
            weapon: Beauty_Weapon.Instance,
            suit: Beauty_Suit.Instance,
            gift: Beauty_Gift.Instance
            )
        {
        }
    }
}
