namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Laetitia : Abnormality
    {
        // Singleton instance
        private static readonly Laetitia _instance = new Laetitia();

        // Public accessor
        public static Laetitia Instance => _instance;

        // Private constructor to prevent external instantiation
        private Laetitia() : base(
            name: "Laetitia",
            riskLevel: RiskLevel.WAW,
            weapon: Laetitia_Weapon.Instance,
            suit: Laetitia_Suit.Instance,
            gift: Laetitia_Gift.Instance
            )
        {
        }
    }
}
