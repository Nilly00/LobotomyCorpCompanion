namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Smiling : Abnormality
    {
        // Singleton instance
        private static readonly Smiling _instance = new();

        // Public accessor
        public static Smiling Instance => _instance;

        // Private constructor to prevent external instantiation
        private Smiling() : base(
            name: "Mountain of Smiling Bodies",
            riskLevel: RiskLevel.ALEPH,
            weapon: Smiling_Weapon.Instance,
            suit: Smiling_Suit.Instance,
            gift: Smiling_Gift.Instance
            )
        {
        }
    }
}