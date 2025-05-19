namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Refraction_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Refraction_Weapon _instance = new Refraction_Weapon();

        // Public accessor
        public static Refraction_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Refraction_Weapon() : base(
            name: "Dimensional Refraction Variant",
            cost: 50,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.WAW,
            damageMin: 15,
            damageMax: 17,
            range: 3,
            attackSpeed: 2.0)
        {
        }
    }
}
