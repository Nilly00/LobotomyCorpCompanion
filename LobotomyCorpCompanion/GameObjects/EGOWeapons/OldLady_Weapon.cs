namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class OldLady_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly OldLady_Weapon _instance = new();

        // Public accessor
        public static OldLady_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private OldLady_Weapon() : base(
            origin: OldLady.Instance,
            name: "Solitude",
            unlockLevel: 3,

            cost: 30,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.WHITE, 
            damageMin: 2,
            damageMax: 3,
            range: 10,
            attackSpeed: 0.7)
        {
        }
    }
}
