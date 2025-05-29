namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Big_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Big_Weapon _instance = new();

        // Public accessor
        public static Big_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Big_Weapon() : base(
            origin: Big.Instance,
            name: "Lamp",
            unlockLevel: 4,

            cost: 70,
            maxCount: 1,
            requirements: [3, 3, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.BLACK, 
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
    }
}
