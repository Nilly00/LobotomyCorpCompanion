namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Alriune : Abnormality
    {
        // Singleton instance
        private static readonly Alriune _instance = new Alriune();

        // Public accessor
        public static Alriune Instance => _instance;

        // Private constructor to prevent external instantiation
        private Alriune() : base(
            name: "Alriune",
            riskLevel: RiskLevel.WAW,
            weapon: Alriune_Weapon.Instance,
            suit: Alriune_Suit.Instance
            )
        {
        }
    }
}
