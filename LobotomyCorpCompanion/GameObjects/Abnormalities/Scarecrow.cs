namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Scarecrow : Abnormality
    {
        // Singleton instance
        private static readonly Scarecrow _instance = new();

        // Public accessor
        public static Scarecrow Instance => _instance;

        // Private constructor to prevent external instantiation
        private Scarecrow() : base(
            name: "Scarecrow Searching for Wisdom",
            riskLevel: RiskLevel.HE,
            weapon: Scarecrow_Weapon.Instance,
            suit: Scarecrow_Suit.Instance,
            gift: Scarecrow_Gift.Instance
            )
        {
        }
    }
}