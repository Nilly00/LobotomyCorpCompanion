namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Prince_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Prince_Weapon _instance = new Prince_Weapon();

        // Public accessor
        public static Prince_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Prince_Weapon() : base(
            name: "Spore",
            cost: 50,
            maxCount: 3,
            requirements: new int[] { 0, 0, 2, 0, 2 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.WAW,
            damageMin: 8,
            damageMax: 16,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to make the target more vulnerable to WHITE damage");
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
