namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Fairy : Abnormality
    {
        // Singleton instance
        private static readonly Fairy _instance = new();

        // Public accessor
        public static Fairy Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fairy() : base(
            name: "Fairy Festival",
            riskLevel: RiskLevel.ZAYIN,
            weapon: Fairy_Weapon.Instance,
            suit: Fairy_Suit.Instance,
            gift: Fairy_Gift.Instance
            )
        {
        }
    }
}
