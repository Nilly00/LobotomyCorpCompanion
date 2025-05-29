namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Apple_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Apple_Weapon _instance = new();

        // Public accessor
        public static Apple_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apple_Weapon() : base(
            origin: Apple.Instance, 
            name: "Green Stem",
            unlockLevel: 4,

            cost: 50,
            maxCount: 3,
            requirements: [0, 0, 3, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.BLACK, 
            damageMin: 8,
            damageMax: 16,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}