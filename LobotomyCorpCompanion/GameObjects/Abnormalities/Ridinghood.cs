namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Ridinghood : Abnormality
    {
        // Singleton instance
        private static readonly Ridinghood _instance = new Ridinghood();

        // Public accessor
        public static Ridinghood Instance => _instance;

        // Private constructor to prevent external instantiation
        private Ridinghood() : base(
            name: "Litle Red Riding Hood",
            riskLevel: RiskLevel.WAW,
            weapon: Ridinghood_Weapon.Instance,
            suit: Ridinghood_Suit.Instance,
            gift: Ridinghood_Gift.Instance
            )
        {
        }
    }
}