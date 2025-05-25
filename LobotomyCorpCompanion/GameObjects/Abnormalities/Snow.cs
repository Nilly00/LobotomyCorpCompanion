namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Snow : Abnormality
    {
        // Singleton instance
        private static readonly Snow _instance = new Snow();

        // Public accessor
        public static Snow Instance => _instance;

        // Private constructor to prevent external instantiation
        private Snow() : base(
            name: "Snow Queen",
            riskLevel: RiskLevel.HE,
            weapon: Snow_Weapon.Instance,
            suit: Snow_Suit.Instance,
            gift: Snow_Gift.Instance
            )
        {
        }
    }
}