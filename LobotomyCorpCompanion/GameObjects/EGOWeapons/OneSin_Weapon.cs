namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class OneSin_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly OneSin_Weapon _instance = new();

        // Public accessor
        public static OneSin_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private OneSin_Weapon() : base(
            origin: OneSin.Instance,
            name: "Penitence",
            unlockLevel: 3,

            cost: 15,
            maxCount: 5,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.ZAYIN,

            type: DamageType.WHITE, 
            damageMin: 5,
            damageMax: 7,
            range: 3,
            attackSpeed: 2.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            if (employee.Ranks[3] > 2)
            {
                employee.SpecialEffects.Add("5% chance to recover 10 SP on attack");
            }
        }
    }
}
