namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Lantern : Abnormality
    {
        // Singleton instance
        private static readonly Lantern _instance = new Lantern();

        // Public accessor
        public static Lantern Instance => _instance;

        // Private constructor to prevent external instantiation
        private Lantern() : base(
            name: "Meat Lantern",
            riskLevel: RiskLevel.TETH,
            weapon: Lantern_Weapon.Instance,
            suit: Lantern_Suit.Instance,
            gift: Lantern_Gift.Instance
            )
        {
        }
    }
}
