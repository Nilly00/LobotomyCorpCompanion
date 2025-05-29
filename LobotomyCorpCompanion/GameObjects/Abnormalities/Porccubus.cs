namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Porccubus : Abnormality
    {
        // Singleton instance
        private static readonly Porccubus _instance = new();

        // Public accessor
        public static Porccubus Instance => _instance;

        // Private constructor to prevent external instantiation
        private Porccubus() : base(
            name: "Porccubus",
            riskLevel: RiskLevel.HE,
            weapon: Porccubus_Weapon.Instance,
            suit: Porccubus_Suit.Instance,
            gift: Porccubus_Gift.Instance
            )
        {
        }
    }
}