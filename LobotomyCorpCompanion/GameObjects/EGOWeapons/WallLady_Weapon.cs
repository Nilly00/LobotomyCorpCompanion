namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class WallLady_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly WallLady_Weapon _instance = new();

        // Public accessor
        public static WallLady_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private WallLady_Weapon() : base(
            origin: WallLady.Instance,
            name: "Screaming Wedge",
            unlockLevel: 3,

            cost: 35,
            maxCount: 2,
            requirements: [0, 2, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            type: DamageType.WHITE,
            damageMin: 7,
            damageMax: 14,
            range: 20,
            attackSpeed: 2.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            if (employee.Ranks[0] < 3 && employee.Ranks[1] < 3)
            {
                employee.SpecialEffects.Add("50% chance to take 5 SP damage with each attack");
            }
        }
    }
}
