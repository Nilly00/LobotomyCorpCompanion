namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Helper_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Helper_Weapon _instance = new Helper_Weapon();

        // Public accessor
        public static Helper_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Helper_Weapon() : base(
            origin: Helper.Instance,
            name: "Grinder Mk4",
            unlockLevel: 4,
            cost: 50,
            maxCount: 1,
            requirements: new int[] { 2, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.HE,
            damageMin: 1,
            damageMax: 3,
            range: 4,
            attackSpeed: 1.6)
        {
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
            //hits 6 times
        }
    }
}
