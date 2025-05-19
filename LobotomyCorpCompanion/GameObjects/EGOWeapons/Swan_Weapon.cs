namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Swan_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Swan_Weapon _instance = new Swan_Weapon();

        // Public accessor
        public static Swan_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Swan_Weapon() : base(
            name: "Black Swan",
            cost: 60,
            maxCount: 2,
            requirements: new int[] { 0, 3, 0, 0, 0 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.WAW,
            damageMin: 5,
            damageMax: 7,
            range: 3,
            attackSpeed: 1.6)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Chance to reflect damage taken");
        }
    }
}