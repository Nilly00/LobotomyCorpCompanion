namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Shoes_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Shoes_Weapon _instance = new();

        // Public accessor
        public static Shoes_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Shoes_Weapon() : base(
            origin: Shoes.Instance,
            name: "Sanguine Desire",
            unlockLevel: 3,

            cost: 40,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            type: DamageType.RED, 
            damageMin: 4,
            damageMax: 7,
            range: 2,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            if (employee.Ranks[2] > 3)
            {
                employee.PermanentBonuses.DamageFlat += 4;
                employee.SpecialEffects.Add("take SP damage equal to 4% of Max. SP on each attack");
            }
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
