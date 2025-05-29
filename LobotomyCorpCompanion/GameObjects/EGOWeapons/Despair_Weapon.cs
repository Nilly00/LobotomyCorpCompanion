namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Despair_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Despair_Weapon _instance = new();

        // Public accessor
        public static Despair_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Despair_Weapon() : base(
            origin: Despair.Instance,
            name: "The Sword Sharpened with Tears",
            unlockLevel: 4,

            cost: 70,
            maxCount: 1,
            requirements: [0, 0, 0, 4, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.WHITE, 
            damageMin: 9,
            damageMax: 12,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void WeaponCalculate()
        {
            //"25% chance to deal an additional 9-18 damage"
        }
    }
}
