namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Wolf_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Wolf_Weapon _instance = new Wolf_Weapon();

        // Public accessor
        public static Wolf_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Wolf_Weapon() : base(
            origin: Wolf.Instance,
            name: "Cobalt Scar",
            unlockLevel: 4,
            cost: 70,
            maxCount: 1,
            requirements: new int[] { 3, 0, 3, 0, 3 },
            type: DamageType.RED,
            riskLevel: RiskLevel.WAW,
            damageMin: 12,
            damageMax: 17,
            range: 3,
            attackSpeed: 1.8)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Deals DOT");
            employee.SpecialEffects.Add("While below 50% HP +50% damage and FRIENDLY FIRE!");
            employee.conditionalBonuses.damagePercent *= 1.5;
        }
    }
}
