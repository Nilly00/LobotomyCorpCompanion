namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Singing_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Singing_Weapon _instance = new();

        // Public accessor
        public static Singing_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Singing_Weapon() : base(
            origin: Singing.Instance,
            name: "Harmony",
            unlockLevel: 4,

            cost: 40,
            maxCount: 2,
            requirements: [2, 0, 0, 0, 2],
            riskLevel: RiskLevel.HE,

            type: DamageType.WHITE, 
            damageMin: 30,
            damageMax: 50,
            range: 15,
            attackSpeed: 5.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("When above 10% HP consume 5% HP twice for +30% damage");
            employee.ConditionalBonuses.DamagePercent *= 1.3;
        }
    }
}
