namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Nest_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Nest_Weapon _instance = new Nest_Weapon();

        // Public accessor
        public static Nest_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nest_Weapon() : base(
            name: "Exuviae",
            cost: 60,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 4 },
            type: DamageType.RED,
            riskLevel: RiskLevel.WAW,
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
