namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Schadenfreude_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Schadenfreude_Weapon _instance = new();

        // Public accessor
        public static Schadenfreude_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Schadenfreude_Weapon() : base(
            origin: Schadenfreude.Instance,
            name: "Gaze",
            unlockLevel: 4,

            cost: 45,
            maxCount: 1,
            requirements: [0, 2, 2, 0, 0],
            riskLevel: RiskLevel.HE,

            type: DamageType.RED, 
            damageMin: 1,
            damageMax: 4,
            range: 4,
            attackSpeed: 2.9)
        {
        }
        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("DOT");
        }
        internal override void WeaponCalculate()
        {
            //todo special calculation
            //hits 9 times
        }
    }
}
