namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Fragments : Abnormality
    {
        // Singleton instance
        private static readonly Fragments _instance = new();

        // Public accessor
        public static Fragments Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fragments() : base(
            name: "Fragment of the Universe",
            riskLevel: RiskLevel.TETH,
            weapon: Fragments_Weapon.Instance,
            suit: Fragments_Suit.Instance,
            gift: Fragments_Gift.Instance
            )
        {
        }
    }
}
