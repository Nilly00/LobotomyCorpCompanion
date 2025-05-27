namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Cute_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Cute_Weapon _instance = new Cute_Weapon();

        // Public accessor
        public static Cute_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Cute_Weapon() : base(
            origin: Cute.Instance,
            name: "SO CUTE!!!",
            unlockLevel: 3,

            cost: 25,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.RED, 
            damageMin: 4,
            damageMax: 6,
            range: 2,
            attackSpeed: 2.0)
        {
        }

        internal override void WeaponCalculate()
        {
            DualWeapon();
        }
    }
}
