namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Wellcheers : Abnormality
    {
        // Singleton instance
        private static readonly Wellcheers _instance = new Wellcheers();

        // Public accessor
        public static Wellcheers Instance => _instance;

        // Private constructor to prevent external instantiation
        private Wellcheers() : base(
            name: "Opened Can of Wellcheers",
            riskLevel: RiskLevel.ZAYIN,
            weapon: Wellcheers_Weapon.Instance,
            suit: Wellcheers_Suit.Instance,
            gift: Wellcheers_Gift.Instance
            )
        {
        }
    }
}