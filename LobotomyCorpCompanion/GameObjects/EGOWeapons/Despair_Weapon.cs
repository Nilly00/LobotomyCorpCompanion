namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Despair_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Despair_Weapon _instance = new Despair_Weapon();

        // Public accessor
        public static Despair_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Despair_Weapon() : base(
            name: "The Sword Sharpened with Tears",
            cost: 70,
            maxCount: 1,
            requirements: new int[] { 0, 0, 0, 4, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.WAW,
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
