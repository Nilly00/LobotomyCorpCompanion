namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Crumbling : Abnormality
    {
        // Singleton instance
        private static readonly Crumbling _instance = new();

        // Public accessor
        public static Crumbling Instance => _instance;

        // Private constructor to prevent external instantiation
        private Crumbling() : base(
            name: "Crumbling Armor",
            riskLevel: RiskLevel.TETH,
            weapon: Crumbling_Weapon.Instance,
            suit: Crumbling_Suit.Instance,
            gift: Crumbling_Gift.Instance
            )
        {
        }
    }
}
