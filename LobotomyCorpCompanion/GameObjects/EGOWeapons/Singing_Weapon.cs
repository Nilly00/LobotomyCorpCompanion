namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Singing_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Singing_Weapon _instance = new Singing_Weapon();

        // Public accessor
        public static Singing_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Singing_Weapon() : base(
            name: "Harmony",
            cost: 40,
            maxCount: 2,
            requirements: new int[] { 2, 0, 0, 0, 2 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.HE,
            damageMin: 30,
            damageMax: 50,
            range: 15,
            attackSpeed: 5.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("When above 10% HP consume 5% HP twice for +30% damage");
            employee.conditionalBoni.damagePercent *= 1.3;
        }
    }
}
