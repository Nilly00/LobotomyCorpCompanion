namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Training_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Training_Weapon _instance = new Training_Weapon();

        // Public accessor
        public static Training_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Training_Weapon() : base(
            name: "Standard Training E.G.O",
            cost: 1,
            maxCount: 5,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.TETH,
            damageMin: 5,
            damageMax: 7,
            range: 4,
            attackSpeed: 1.0)
        {
        }
    }
}
