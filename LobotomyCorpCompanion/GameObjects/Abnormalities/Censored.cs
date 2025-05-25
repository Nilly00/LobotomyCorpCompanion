namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Censored : Abnormality
    {
        // Singleton instance
        private static readonly Censored _instance = new Censored();

        // Public accessor
        public static Censored Instance => _instance;

        // Private constructor to prevent external instantiation
        private Censored() : base(
            name: "CENSORED",
            riskLevel: RiskLevel.ALEPH,
            weapon: Censored_Weapon.Instance,
            gift: Censored_Gift.Instance
            )
        {
        }
    }
}
