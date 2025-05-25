namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Scorched : Abnormality
    {
        // Singleton instance
        private static readonly Scorched _instance = new Scorched();

        // Public accessor
        public static Scorched Instance => _instance;

        // Private constructor to prevent external instantiation
        private Scorched() : base(
            name: "Scorched Girl",
            riskLevel: RiskLevel.TETH,
            weapon: Scorched_Weapon.Instance,
            suit: Scorched_Suit.Instance,
            gift: Scorched_Gift.Instance
            )
        {
        }
    }
}