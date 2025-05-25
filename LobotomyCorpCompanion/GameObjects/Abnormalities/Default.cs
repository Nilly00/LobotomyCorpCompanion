namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Default : Abnormality
    {
        // Singleton instance
        private static readonly Default _instance = new Default();

        // Public accessor
        public static Default Instance => _instance;

        // Private constructor to prevent external instantiation
        private Default() : base(
            name: "Standard",
            riskLevel: RiskLevel.ZAYIN,
            weapon: Default_Weapon.Instance,
            suit: Default_Suit.Instance
            )
        {
        }
    }
}
