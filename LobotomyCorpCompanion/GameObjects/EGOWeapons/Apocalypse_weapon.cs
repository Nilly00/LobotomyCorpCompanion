namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Apocalypse_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Apocalypse_Weapon _instance = new();

        // Public accessor
        public static Apocalypse_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apocalypse_Weapon() : base(
            origin: Apocalypse.Instance,
            name: "Twilight",
            unlockLevel: 0,

            cost: -1,
            maxCount: 1,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.ALEPH,

            type: DamageType.SPECIAL, 
            damageMin: 0,
            damageMax: 0,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override bool CheckRequirements(Employee employee)
        {
            return base.CheckRequirements(employee) &&
                employee.MinStats.PrimaryStats.Fortitude >= 110 &&
                employee.MinStats.PrimaryStats.Prudence >= 110 &&
                employee.MinStats.PrimaryStats.Temperance >= 110 &&
                employee.MinStats.PrimaryStats.Justice >= 110;
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Prevents Apocalypse Bird from appearing.");
        }

        internal override void WeaponCalculate()
        {
            //todo special calculate
        }
    }
}
