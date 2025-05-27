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
            origin: Scarecrow.Instance,
            name: "Harvest",
            unlockLevel: 3,

            cost: 45,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            type: DamageType.BLACK, 
            damageMin: 6,
            damageMax: 12,
            range: 4,
            attackSpeed: 1.5)
        {
        }
    }
}
