namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Shoes : Abnormality
    {
        // Singleton instance
        private static readonly Shoes _instance = new Shoes();

        // Public accessor
        public static Shoes Instance => _instance;

        // Private constructor to prevent external instantiation
        private Shoes() : base(
            name: "The Red Shoes",
            riskLevel: RiskLevel.HE,
            weapon: Shoes_Weapon.Instance,
            suit: Shoes_Suit.Instance,
            gift: Shoes_Gift.Instance
            )
        {
        }
    }
}