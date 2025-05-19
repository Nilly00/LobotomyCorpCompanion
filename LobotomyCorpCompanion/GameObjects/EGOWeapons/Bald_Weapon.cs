namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Bald_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Bald_Weapon _instance = new Bald_Weapon();

        // Public accessor
        public static Bald_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bald_Weapon() : base(
            name: "Tough",
            cost: 15,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.TETH,
            damageMin: 2,
            damageMax: 4,
            range: 10,
            attackSpeed: 0.7)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Employee Must be Bald");
        }
    }
}
