namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Singing : Abnormality
    {
        // Singleton instance
        private static readonly Singing _instance = new Singing();

        // Public accessor
        public static Singing Instance => _instance;

        // Private constructor to prevent external instantiation
        private Singing() : base(
            name: "Singing Machine",
            riskLevel: RiskLevel.HE,
            weapon: Singing_Weapon.Instance,
            gift: Singing_Gift.Instance
            )
        {
        }
    }
}