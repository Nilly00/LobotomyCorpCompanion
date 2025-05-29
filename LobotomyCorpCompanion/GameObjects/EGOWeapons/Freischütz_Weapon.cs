namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Freischütz_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Freischütz_Weapon _instance = new();

        // Public accessor
        public static Freischütz_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Freischütz_Weapon() : base(
            origin: Freischütz.Instance,
            name: "Magic Bullet",
            unlockLevel: 4,

            cost: 40,
            maxCount: 1,
            requirements: [0, 0, 3, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.BLACK, 
            damageMin: 20,
            damageMax: 22,
            range: 50,
            attackSpeed: 2.3)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Piercing Bullet crosses the entire room.");
            employee.SpecialEffects.Add("Friendly Fire!");
        }
    }
}
