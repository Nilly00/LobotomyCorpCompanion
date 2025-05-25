namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Parasite : Abnormality
    {
        // Singleton instance
        private static readonly Parasite _instance = new Parasite();

        // Public accessor
        public static Parasite Instance => _instance;

        // Private constructor to prevent external instantiation
        private Parasite() : base(
            name: "Parasite Tree",
            riskLevel: RiskLevel.WAW,
            weapon: Parasite_Weapon.Instance,
            suit: Parasite_Suit.Instance,
            gift: Parasite_Gift.Instance
            )
        {
        }
    }
}