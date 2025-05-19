namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Galaxy_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Galaxy_Weapon _instance = new Galaxy_Weapon();

        // Public accessor
        public static Galaxy_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Galaxy_Weapon() : base(
            name: "Our Galaxy",
            cost: 45,
            maxCount: 1,
            requirements: new int[] { 0, 2, 0, 0, 2 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.HE,
            damageMin: 9,
            damageMax: 15,
            range: 8,
            attackSpeed: 2.0)
        {
        }
    }
}
