namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bear : Abnormality
    {
        // Singleton instance
        private static readonly Bear _instance = new Bear();

        // Public accessor
        public static Bear Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bear() : base(
            name: "Happy Bear",
            riskLevel: RiskLevel.HE,
            weapon: Bear_Weapon.Instance,
            suit: Bear_Suit.Instance,
            gift: Bear_Gift.Instance
            )
        {
        }
    }
}
