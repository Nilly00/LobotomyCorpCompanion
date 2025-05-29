namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Forsaken : Abnormality
    {
        // Singleton instance
        private static readonly Forsaken _instance = new();

        // Public accessor
        public static Forsaken Instance => _instance;

        // Private constructor to prevent external instantiation
        private Forsaken() : base(
            name: "Forsaken Murderer",
            riskLevel: RiskLevel.TETH,
            weapon: Forsaken_Weapon.Instance,
            suit: Forsaken_Suit.Instance,
            gift: Forsaken_Gift.Instance
            )
        {
        }
    }
}
