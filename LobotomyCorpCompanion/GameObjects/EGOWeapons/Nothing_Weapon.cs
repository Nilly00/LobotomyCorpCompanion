namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Nothing_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Nothing_Weapon _instance = new Nothing_Weapon();

        // Public accessor
        public static Nothing_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nothing_Weapon() : base(
            name: "Mimicry",
            cost: 222,
            maxCount: 1,
            requirements: new int[] { 5, 0, 0, 0, 5 },
            type: DamageType.RED,
            riskLevel: RiskLevel.ALEPH,
            damageMin: 10,
            damageMax: 14,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Recover 25% of damage dealt to the target as HP");
        }
    }
}
