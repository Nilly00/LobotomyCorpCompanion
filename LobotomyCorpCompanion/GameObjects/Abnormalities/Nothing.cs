namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Nothing : Abnormality
    {
        // Singleton instance
        private static readonly Nothing _instance = new();

        // Public accessor
        public static Nothing Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nothing() : base(
            name: "Nothing There",
            riskLevel: RiskLevel.ALEPH,
            weapon: Nothing_Weapon.Instance,
            suit: Nothing_Suit.Instance,
            gift: Nothing_Gift.Instance
            )
        {
        }
    }
}
