namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Hatred : Abnormality
    {
        // Singleton instance
        private static readonly Hatred _instance = new Hatred();

        // Public accessor
        public static Hatred Instance => _instance;

        // Private constructor to prevent external instantiation
        private Hatred() : base(
            name: "The Queen of Hatred",
            riskLevel: RiskLevel.WAW,
            weapon: Hatred_Weapon.Instance,
            suit: Hatred_Suit.Instance,
            gift: Hatred_Gift.Instance
            )
        {
        }
    }
}
