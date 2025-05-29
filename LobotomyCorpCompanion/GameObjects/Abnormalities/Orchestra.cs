namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Orchestra : Abnormality
    {
        // Singleton instance
        private static readonly Orchestra _instance = new();

        // Public accessor
        public static Orchestra Instance => _instance;

        // Private constructor to prevent external instantiation
        private Orchestra() : base(
            name: "The Silent Orchestra",
            riskLevel: RiskLevel.ALEPH,
            weapon: Orchestra_Weapon.Instance,
            suit: Orchestra_Suit.Instance,
            gift: Orchestra_Gift.Instance
            )
        {
        }
    }
}
