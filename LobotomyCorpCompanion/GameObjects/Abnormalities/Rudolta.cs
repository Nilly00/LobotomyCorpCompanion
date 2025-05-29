namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Rudolta : Abnormality
    {
        // Singleton instance
        private static readonly Rudolta _instance = new();

        // Public accessor
        public static Rudolta Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rudolta() : base(
            name: "Rudolta of the Sleigh",
            riskLevel: RiskLevel.HE,
            weapon: Rudolta_Weapon.Instance,
            suit: Rudolta_Suit.Instance,
            gift: Rudolta_Gift.Instance
            )
        {
        }
    }
}