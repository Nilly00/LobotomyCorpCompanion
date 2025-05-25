namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Despair : Abnormality
    {
        // Singleton instance
        private static readonly Despair _instance = new Despair();

        // Public accessor
        public static Despair Instance => _instance;

        // Private constructor to prevent external instantiation
        private Despair() : base(
            name: "The Knight of Despair",
            riskLevel: RiskLevel.WAW,
            weapon: Despair_Weapon.Instance,
            suit: Despair_Suit.Instance,
            gift: Despair_Gift.Instance
            )
        {
        }
    }
}
