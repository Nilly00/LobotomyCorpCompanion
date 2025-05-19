namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Spider_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Spider_Weapon _instance = new Spider_Weapon();

        // Public accessor
        public static Spider_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Spider_Weapon() : base(
            name: "Red Eyes",
            cost: 20,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.TETH,
            damageMin: 7,
            damageMax: 9,
            range: 3,
            attackSpeed: 2.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            if (employee.ranks[0] < 1)
            {
                employee.SpecialEffects.Add("+2.5 MS during supression or combat");
                employee.conditionalBoni.secondaryStats.MS += 2;
            }
        }
    }
}
