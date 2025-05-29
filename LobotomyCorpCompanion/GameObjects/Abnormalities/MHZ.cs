namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class MHZ : Abnormality
    {
        // Singleton instance
        private static readonly MHZ _instance = new();

        // Public accessor
        public static MHZ Instance => _instance;

        // Private constructor to prevent external instantiation
        private MHZ() : base(
            name: "1.76 MHz",
            riskLevel: RiskLevel.TETH,
            suit: MHZ_Suit.Instance,
            gift: MHZ_Gift.Instance
            )
        {
        }
    }
}
