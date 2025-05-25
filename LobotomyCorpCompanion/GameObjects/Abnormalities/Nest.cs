namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Nest : Abnormality
    {
        // Singleton instance
        private static readonly Nest _instance = new Nest();

        // Public accessor
        public static Nest Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nest() : base(
            name: "The Naked Nest",
            riskLevel: RiskLevel.WAW,
            weapon: Nest_Weapon.Instance,
            suit: Nest_Suit.Instance,
            gift: Nest_Gift.Instance
            )
        {
        }
    }
}
