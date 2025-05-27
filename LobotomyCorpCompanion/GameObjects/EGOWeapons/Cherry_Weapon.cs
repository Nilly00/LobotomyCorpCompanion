namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Cherry_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Cherry_Weapon _instance = new Cherry_Weapon();

        // Public accessor
        public static Cherry_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Cherry_Weapon() : base(
            origin: Cherry.Instance,
            name: "Cherry Blossoms",
            unlockLevel: 3,

            cost: 25,
            maxCount: 1,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.WHITE, 
            damageMin: 1,
            damageMax: 2,
            range: 5,
            attackSpeed: 1.0)
        {
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
