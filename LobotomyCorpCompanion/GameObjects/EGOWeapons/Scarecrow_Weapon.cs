namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Scarecrow_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Scarecrow_Weapon _instance = new Scarecrow_Weapon();

        // Public accessor
        public static Scarecrow_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Scarecrow_Weapon() : base(
            name: "Harvest",
            cost: 45,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.HE,
            damageMin: 6,
            damageMax: 12,
            range: 4,
            attackSpeed: 1.5)
        {
        }
    }
}
