namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Luna : Abnormality
    {
        // Singleton instance
        private static readonly Luna _instance = new Luna();

        // Public accessor
        public static Luna Instance => _instance;

        // Private constructor to prevent external instantiation
        private Luna() : base(
            name: "Il Pianto della Luna",
            riskLevel: RiskLevel.WAW,
            weapon: Luna_Weapon.Instance,
            suit: Luna_Suit.Instance,
            gift: Luna_Gift.Instance
            )
        {
        }
    }
}
