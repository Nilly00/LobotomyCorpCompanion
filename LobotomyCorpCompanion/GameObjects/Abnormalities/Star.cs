namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Star : Abnormality
    {
        // Singleton instance
        private static readonly Star _instance = new();

        // Public accessor
        public static Star Instance => _instance;

        // Private constructor to prevent external instantiation
        private Star() : base(
            name: "Blue Star",
            riskLevel: RiskLevel.ALEPH,
            weapon: Star_Weapon.Instance,
            suit: Star_Suit.Instance,
            gift: Star_Gift.Instance
            )
        {
        }
    }
}