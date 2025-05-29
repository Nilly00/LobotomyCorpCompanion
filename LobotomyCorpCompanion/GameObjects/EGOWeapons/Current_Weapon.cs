namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Current_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Current_Weapon _instance = new();

        // Public accessor
        public static Current_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Current_Weapon() : base(
            origin: Current.Instance,
            name: "Ecstasy",
            unlockLevel: 4,

            cost: 60,
            maxCount: 2,
            requirements: [2, 0, 0, 0, 3],
            riskLevel: RiskLevel.WAW,

            type: DamageType.WHITE, 
            damageMin: 2,
            damageMax: 4,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
