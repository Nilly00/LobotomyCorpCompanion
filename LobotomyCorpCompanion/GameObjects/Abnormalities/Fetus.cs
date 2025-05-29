namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Fetus : Abnormality
    {
        // Singleton instance
        private static readonly Fetus _instance = new();

        // Public accessor
        public static Fetus Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fetus() : base(
            name: "Nameless Fetus",
            riskLevel: RiskLevel.HE,
            weapon: Fetus_Weapon.Instance,
            suit: Fetus_Suit.Instance,
            gift: Fetus_Gift.Instance
            )
        {
        }
    }
}
