namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class OneSin_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly OneSin_Weapon _instance = new OneSin_Weapon();

        // Public accessor
        public static OneSin_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private OneSin_Weapon() : base(
            name: "Penitence",
            cost: 15,
            maxCount: 5,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.ZAYIN,
            damageMin: 5,
            damageMax: 7,
            range: 3,
            attackSpeed: 2.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            if (employee.ranks[3] > 2)
            {
                employee.SpecialEffects.Add("5% chance to recover 10 SP on attack");
            }
        }
    }
}
