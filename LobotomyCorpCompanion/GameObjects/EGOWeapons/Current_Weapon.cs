namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Current_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Current_Weapon _instance = new Current_Weapon();

        // Public accessor
        public static Current_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Current_Weapon() : base(
            name: "Ecstasy",
            cost: 60,
            maxCount: 2,
            requirements: new int[] { 2, 0, 0, 0, 3 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.WAW,
            damageMin: 2,
            damageMax: 4,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
