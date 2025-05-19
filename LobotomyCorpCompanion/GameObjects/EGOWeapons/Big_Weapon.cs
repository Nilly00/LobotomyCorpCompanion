namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Big_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Big_Weapon _instance = new Big_Weapon();

        // Public accessor
        public static Big_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Big_Weapon() : base(
            name: "Lamp",
            cost: 70,
            maxCount: 1,
            requirements: new int[] { 3, 3, 0, 0, 0 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.WAW,
            damageMin: 22,
            damageMax: 28,
            range: 5,
            attackSpeed: 3.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to make the target more vulnerable to BLACK damage");
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
