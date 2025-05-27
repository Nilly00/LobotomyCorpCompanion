namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Porccubus_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Porccubus_Weapon _instance = new Porccubus_Weapon();

        // Public accessor
        public static Porccubus_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Porccubus_Weapon() : base(
            origin: Porccubus.Instance,
            name: "Pleasure",
            unlockLevel: 4,

            cost: 45,
            maxCount: 1,
            requirements: [0, 0, 3, 0, 0],
            riskLevel: RiskLevel.HE,

            type: DamageType.BLACK, 
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
