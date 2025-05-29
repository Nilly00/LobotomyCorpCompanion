namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Luna_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Luna_Weapon _instance = new();

        // Public accessor
        public static Luna_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Luna_Weapon() : base(
            origin: Luna.Instance,
            name: "Moonlight",
            unlockLevel: 4,

            cost: 70,
            maxCount: 1,
            requirements: [3, 0, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.WHITE, 
            damageMin: 8,
            damageMax: 10,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Special Attack granting BLACK shields to employees in the room");
        }
    }
}