namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Star_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Star_Weapon _instance = new();

        // Public accessor
        public static Star_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Star_Weapon() : base(
            origin: Star.Instance,
            name: "Sound of a Star",
            unlockLevel: 4,

            cost: 222,
            maxCount: 1,
            requirements: [0, 5, 5, 0, 5],
            riskLevel: RiskLevel.ALEPH,

            type: DamageType.WHITE,
            damageMin: 8,
            damageMax: 12,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            //todo special effect
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
