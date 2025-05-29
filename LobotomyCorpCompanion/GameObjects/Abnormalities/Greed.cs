namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Greed : Abnormality
    {
        // Singleton instance
        private static readonly Greed _instance = new();

        // Public accessor
        public static Greed Instance => _instance;

        // Private constructor to prevent external instantiation
        private Greed() : base(
            name: "The King of Greed",
            riskLevel: RiskLevel.WAW,
            weapon: Greed_Weapon.Instance,
            suit: Greed_Suit.Instance,
            gift: Greed_Gift.Instance
            )
        {
        }
    }
}
