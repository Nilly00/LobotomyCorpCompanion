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
            origin: Nothing.Instance,
            name: "Mimicry",
            unlockLevel: 4,

            cost: 222,
            maxCount: 1,
            requirements: [5, 0, 0, 0, 5],
            riskLevel: RiskLevel.ALEPH,

            type: DamageType.RED, 
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
