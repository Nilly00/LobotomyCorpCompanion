namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Nest_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Nest_Weapon _instance = new();

        // Public accessor
        public static Nest_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nest_Weapon() : base(
            origin: Nest.Instance,
            name: "Exuviae",
            unlockLevel: 4,

            cost: 60,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 4],
            riskLevel: RiskLevel.WAW,

            type: DamageType.RED, 
            damageMin: 35,
            damageMax: 50,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to make the target more vulnerable to RED damage");
        }
    }
}
