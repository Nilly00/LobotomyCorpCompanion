namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Bear_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Bear_Weapon _instance = new Bear_Weapon();

        // Public accessor
        public static Bear_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bear_Weapon() : base(
            origin: Bear.Instance,
            name: "Bear Paws",
            unlockLevel: 3,
            cost: 40,
            maxCount: 2,
            requirements: new int[] { 2, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.HE,
            damageMin: 6,
            damageMax: 7,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void WeaponCalculate()
        {
            DualWeapon();
        }
    }
}
