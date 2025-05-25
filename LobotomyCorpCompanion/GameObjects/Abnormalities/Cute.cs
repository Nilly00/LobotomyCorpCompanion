namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Cute : Abnormality
    {
        // Singleton instance
        private static readonly Cute _instance = new Cute();

        // Public accessor
        public static Cute Instance => _instance;

        // Private constructor to prevent external instantiation
        private Cute() : base(
            name: "Ppodae",
            riskLevel: RiskLevel.TETH,
            weapon: Cute_Weapon.Instance,
            suit: Cute_Suit.Instance,
            gift: Cute_Gift.Instance
            )
        {
        }
    }
}
