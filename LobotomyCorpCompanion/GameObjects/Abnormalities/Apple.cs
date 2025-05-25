namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Apple : Abnormality
    {
        // Singleton instance
        private static readonly Apple _instance = new Apple();

        // Public accessor
        public static Apple Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apple() : base(
            name: "Snow White's Apple",
            riskLevel: RiskLevel.WAW,
            weapon: Apple_Weapon.Instance,
            suit: Apple_Suit.Instance,
            gift: Apple_Gift.Instance
            )
        {
        }
    }
}
