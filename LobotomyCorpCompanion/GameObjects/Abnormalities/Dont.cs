namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Dont : Abnormality
    {
        // Singleton instance
        private static readonly Dont _instance = new Dont();

        // Public accessor
        public static Dont Instance => _instance;

        // Private constructor to prevent external instantiation
        private Dont() : base(
            name: "Don't Touch Me",
            riskLevel: RiskLevel.ZAYIN
            )
        {
        }
    }
}