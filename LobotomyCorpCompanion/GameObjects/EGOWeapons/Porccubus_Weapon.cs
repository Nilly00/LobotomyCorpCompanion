namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Porcubus_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Porcubus_Weapon _instance = new Porcubus_Weapon();

        // Public accessor
        public static Porcubus_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Porcubus_Weapon() : base(
            name: "Pleasure",
            cost: 45,
            maxCount: 1,
            requirements: new int[] { 0, 0, 3, 0, 0 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.HE,
            damageMin: 1,
            damageMax: 4,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("DOT");
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
