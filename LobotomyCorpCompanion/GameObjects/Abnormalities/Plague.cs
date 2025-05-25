namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Plague : Abnormality
    {
        // Singleton instance
        private static readonly Plague _instance = new Plague();

        // Public accessor
        public static Plague Instance => _instance;

        // Private constructor to prevent external instantiation
        private Plague() : base(
            name: "The Plague Doctor",
            riskLevel: RiskLevel.ZAYIN,
            gift: Plague_Gift.Instance
            )
        {
        }
    }
}
