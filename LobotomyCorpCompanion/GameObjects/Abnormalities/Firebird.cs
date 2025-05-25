namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Firebird : Abnormality
    {
        // Singleton instance
        private static readonly Firebird _instance = new Firebird();

        // Public accessor
        public static Firebird Instance => _instance;

        // Private constructor to prevent external instantiation
        private Firebird() : base(
            name: "The Firebird",
            riskLevel: RiskLevel.WAW,
            weapon: Firebird_Weapon.Instance,
            suit: Firebird_Suit.Instance,
            gift: Firebird_Gift.Instance
            )
        {
        }
    }
}
