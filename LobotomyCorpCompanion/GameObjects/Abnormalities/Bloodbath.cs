namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bloodbath : Abnormality
    {
        // Singleton instance
        private static readonly Bloodbath _instance = new Bloodbath();

        // Public accessor
        public static Bloodbath Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bloodbath() : base(
            name: "Bloodbath",
            riskLevel: RiskLevel.TETH,
            weapon: Bloodbath_Weapon.Instance,
            suit: Bloodbath_Suit.Instance,
            gift: Bloodbath_Gift.Instance
            )
        {
        }
    }
}
