namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bald : Abnormality
    {
        // Singleton instance
        private static readonly Bald _instance = new();

        // Public accessor
        public static Bald Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bald() : base(
            name: "You're Bald...",
            riskLevel: RiskLevel.ZAYIN,
            weapon: Bald_Weapon.Instance,
            suit: Bald_Suit.Instance,
            gift: Bald_Gift.Instance
            )
        {
        }
    }
}
