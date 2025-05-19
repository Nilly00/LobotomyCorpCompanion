namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Censored_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Censored_Weapon _instance = new Censored_Weapon();

        // Public Censored
        public static Censored_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Censored_Weapon() : base(
            name: "CENSORED",
            cost: 222,
            maxCount: 1,
            requirements: new int[] { 5, 0, 0, 0, 5 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.ALEPH,
            damageMin: 7,
            damageMax: 11,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Recover 40% of damage taken when hit");
            //todo fully calculate this 
        }
        /*
        internal override void WeaponCalculate()
        {
            employee.SpecialEffects.Add("Hits twice");
            employee.SpecialEffects.Add("10% chance to deal 15-30 damage 3 times");
        }*/
    }
}
