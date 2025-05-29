namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Punishing : Abnormality
    {
        // Singleton instance
        private static readonly Punishing _instance = new();

        // Public accessor
        public static Punishing Instance => _instance;

        // Private constructor to prevent external instantiation
        private Punishing() : base(
            name: "Punishing",
            riskLevel: RiskLevel.TETH,
            weapon: Punishing_Weapon.Instance,
            suit: Punishing_Suit.Instance,
            gift: Punishing_Gift.Instance
            )
        {
        }
    }
}