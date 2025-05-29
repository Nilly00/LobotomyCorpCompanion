namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Freischütz : Abnormality
    {
        // Singleton instance
        private static readonly Freischütz _instance = new();

        // Public accessor
        public static Freischütz Instance => _instance;

        // Private constructor to prevent external instantiation
        private Freischütz() : base(
            name: "Der Freischütz",
            riskLevel: RiskLevel.HE,
            weapon: Freischütz_Weapon.Instance,
            suit: Freischütz_Suit.Instance,
            gift: Freischütz_Gift.Instance
            )
        {
        }
    }
}
