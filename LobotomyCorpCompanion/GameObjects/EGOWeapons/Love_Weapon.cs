namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Love_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Love_Weapon _instance = new Love_Weapon();

        // Public accessor
        public static Love_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Love_Weapon() : base(
            origin: Love.Instance,
            name: "Adoration",
            unlockLevel: 4,
            cost: 222,
            maxCount: 1,
            requirements: new int[] { 0, 0, 5, 0, 5 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.ALEPH,
            damageMin: 22,
            damageMax: 44,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Reduces the Movement Speed of the target by 30% for 3 seconds");
            employee.SpecialEffects.Add("DOT");
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
