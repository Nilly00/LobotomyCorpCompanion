namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Refraction_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Refraction_Weapon _instance = new();

        // Public accessor
        public static Refraction_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Refraction_Weapon() : base(
            origin: Refraction.Instance,
            name: "Dimensional Refraction Variant",
            unlockLevel: 4,

            cost: 50,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.WHITE, 
            damageMin: 15,
            damageMax: 17,
            range: 3,
            attackSpeed: 2.0)
        {
        }
    }
}
