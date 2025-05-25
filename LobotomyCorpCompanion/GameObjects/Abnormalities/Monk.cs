namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Monk : Abnormality
    {
        // Singleton instance
        private static readonly Monk _instance = new Monk();

        // Public accessor
        public static Monk Instance => _instance;

        // Private constructor to prevent external instantiation
        private Monk() : base(
            name: "Clouded Monk",
            riskLevel: RiskLevel.WAW,
            weapon: Monk_Weapon.Instance,
            suit: Monk_Suit.Instance,
            gift: Monk_Gift.Instance

            //todo monk ignores suit level when dealing damage. Implement special calculation
            )
        {
        }
    }
}
