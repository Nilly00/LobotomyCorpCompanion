namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Hatred_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Hatred_Weapon _instance = new();

        // Public accessor
        public static Hatred_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Hatred_Weapon() : base(
            origin: Hatred.Instance,
            name: "In the Name of Love and Hate",
            unlockLevel: 4,

            cost: 70,
            maxCount: 1,
            requirements: [3, 0, 0, 3, 4],
            riskLevel: RiskLevel.WAW,

            type: DamageType.HEALING, 
            damageMin: 5,
            damageMax: 8,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Heals other Employees instead of attacking Monsters");
        }
    }
}
