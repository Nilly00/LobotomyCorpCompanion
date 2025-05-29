namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bee : Abnormality
    {
        // Singleton instance
        private static readonly Bee _instance = new();

        // Public accessor
        public static Bee Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bee() : base(
            name: "Queen Bee",
            riskLevel: RiskLevel.WAW,
            weapon: Bee_Weapon.Instance,
            suit: Bee_Suit.Instance,
            gift: Bee_Gift.Instance
            )
        {
        }
    }
}
