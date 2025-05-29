namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Schadenfreude : Abnormality
    {
        // Singleton instance
        private static readonly Schadenfreude _instance = new();

        // Public accessor
        public static Schadenfreude Instance => _instance;

        // Private constructor to prevent external instantiation
        private Schadenfreude() : base(
            name: "Schadenfreude",
            riskLevel: RiskLevel.HE,
            weapon: Schadenfreude_Weapon.Instance,
            suit: Schadenfreude_Suit.Instance,
            gift: Schadenfreude_Gift.Instance
            )
        {
        }
    }
}