namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Woodsman : Abnormality
    {
        // Singleton instance
        private static readonly Woodsman _instance = new();

        // Public accessor
        public static Woodsman Instance => _instance;

        // Private constructor to prevent external instantiation
        private Woodsman() : base(
            name: "Warm-hearted Woodsman",
            riskLevel: RiskLevel.HE,
            weapon: Woodsman_Weapon.Instance,
            suit: Woodsman_Suit.Instance,
            gift: Woodsman_Gift.Instance
            )
        {
        }
    }
}