namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Butterflies : Abnormality
    {
        // Singleton instance
        private static readonly Butterflies _instance = new Butterflies();

        // Public accessor
        public static Butterflies Instance => _instance;

        // Private constructor to prevent external instantiation
        private Butterflies() : base(
            name: "Funeral of the dead Butterflies",
            riskLevel: RiskLevel.HE,
            weapon: Butterflies_Weapon.Instance,
            suit: Butterflies_Suit.Instance,
            gift: Butterflies_Gift.Instance
            )
        {
        }
    }
}
