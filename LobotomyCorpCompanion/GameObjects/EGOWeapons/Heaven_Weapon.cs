namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Heaven_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Heaven_Weapon _instance = new Heaven_Weapon();

        // Public accessor
        public static Heaven_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Heaven_Weapon() : base(
            origin: Heaven.Instance,
            name: "Heaven",
            unlockLevel: 4,
            cost: 40,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 3 },
            type: DamageType.RED,
            riskLevel: RiskLevel.WAW,
            damageMin: 8,
            damageMax: 16,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
