namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Galaxy : Abnormality
    {
        // Singleton instance
        private static readonly Galaxy _instance = new();

        // Public accessor
        public static Galaxy Instance => _instance;

        // Private constructor to prevent external instantiation
        private Galaxy() : base(
            name: "Child of the Galaxy",
            riskLevel: RiskLevel.HE,
            weapon: Galaxy_Weapon.Instance,
            suit: Galaxy_Suit.Instance,
            gift: Galaxy_Gift.Instance
            )
        {
        }
    }
}
