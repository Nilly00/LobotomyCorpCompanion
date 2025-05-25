namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class WallLady : Abnormality
    {
        // Singleton instance
        private static readonly WallLady _instance = new WallLady();

        // Public accessor
        public static WallLady Instance => _instance;

        // Private constructor to prevent external instantiation
        private WallLady() : base(
            name: "The Lady Facing the Wall",
            riskLevel: RiskLevel.TETH,
            weapon: WallLady_Weapon.Instance,
            suit: WallLady_Suit.Instance
            )
        {
        }
    }
}
