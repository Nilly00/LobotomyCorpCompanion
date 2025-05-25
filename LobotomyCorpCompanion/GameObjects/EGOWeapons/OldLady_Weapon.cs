namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class OldLady_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly OldLady_Weapon _instance = new OldLady_Weapon();

        // Public accessor
        public static OldLady_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private OldLady_Weapon() : base(
            origin: OldLady.Instance,
            name: "Solitude",
            unlockLevel: 3,
            cost: 30,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.TETH,
            damageMin: 2,
            damageMax: 3,
            range: 10,
            attackSpeed: 0.7)
        {
        }
    }
}
