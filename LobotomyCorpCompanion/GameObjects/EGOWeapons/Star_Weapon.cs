namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Star_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Star_Weapon _instance = new Star_Weapon();

        // Public accessor
        public static Star_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Star_Weapon() : base(
            name: "Sound of a Star",
            cost: 222,
            maxCount: 1,
            requirements: new int[] { 0, 5, 5, 0, 5 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.ALEPH,
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
