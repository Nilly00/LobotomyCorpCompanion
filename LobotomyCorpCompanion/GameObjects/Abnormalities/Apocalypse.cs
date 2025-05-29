namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Apocalypse : Abnormality
    {
        // Singleton instance
        private static readonly Apocalypse _instance = new();

        // Public accessor
        public static Apocalypse Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apocalypse() : base(
            name: "Apocalypse Bird",
            riskLevel: RiskLevel.ALEPH,
            weapon: Apocalypse_Weapon.Instance,
            suit: Apocalypse_Suit.Instance,
            gift: Apocalypse_Gift.Instance
            )
        {
        }
    }
}
