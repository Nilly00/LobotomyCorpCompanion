namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Smiling_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Smiling_Weapon _instance = new Smiling_Weapon();

        // Public accessor
        public static Smiling_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Smiling_Weapon() : base(
            name: "Smile",
            cost: 222,
            maxCount: 1,
            requirements: new int[] { 0, 0, 5, 0, 5 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.ALEPH,
            damageMin: 12,
            damageMax: 18,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Each time an attack target dies, Fortitude and Justice will rise by 3 up to 30");
            employee.conditionalBoni.primaryStats.Fortitude += 30;
            employee.conditionalBoni.primaryStats.Justice += 30;
            employee.SpecialEffects.Add("Decrease the target’s Movement Speed on normal attack");
        }

        internal override void WeaponCalculate()
        {
            //"30% chance to deal 55-65 Damage AOE"
            //todo special calculation
        }
    }
}
