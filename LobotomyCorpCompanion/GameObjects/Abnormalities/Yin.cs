namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Yin : Abnormality
    {
        // Singleton instance
        private static readonly Yin _instance = new Yin();

        // Public accessor
        public static Yin Instance => _instance;

        // Private constructor to prevent external instantiation
        private Yin() : base(
            name: "Yin",
            riskLevel: RiskLevel.WAW,
            weapon: Yin_Weapon.Instance,
            suit: Yin_Suit.Instance,
            gift: Yin_Gift.Instance
            )
        {
        }
    }
}