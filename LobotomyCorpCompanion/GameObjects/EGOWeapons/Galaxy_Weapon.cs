namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Galaxy_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Galaxy_Weapon _instance = new();

        // Public accessor
        public static Galaxy_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Galaxy_Weapon() : base(
            origin: Galaxy.Instance,
            name: "Our Galaxy",
            unlockLevel: 4,

            cost: 45,
            maxCount: 1,
            requirements: [0, 2, 0, 0, 2],
            riskLevel: RiskLevel.HE,

            type: DamageType.BLACK, 
            damageMin: 9,
            damageMax: 15,
            range: 8,
            attackSpeed: 2.0)
        {
        }
    }
}
