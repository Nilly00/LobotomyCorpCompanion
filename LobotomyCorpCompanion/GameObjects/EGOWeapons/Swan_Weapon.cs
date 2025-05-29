namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Swan_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Swan_Weapon _instance = new();

        // Public accessor
        public static Swan_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Swan_Weapon() : base(
            origin: Swan.Instance,
            name: "Black Swan",
            unlockLevel: 4,

            cost: 60,
            maxCount: 2,
            requirements: [0, 3, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.BLACK,
            damageMin: 5,
            damageMax: 7,
            range: 3,
            attackSpeed: 1.6)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("25% Chance to reflect damage taken");
        }
    }
}