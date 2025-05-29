namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Yin_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Yin_Weapon _instance = new();

        // Public accessor
        public static Yin_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Yin_Weapon() : base(
            origin: Yin.Instance,
            name: "Discord",
            unlockLevel: 4,

            cost: 60,
            maxCount: 2,
            requirements: [0, 0, 3, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.BLACK,
            damageMin: 8,
            damageMax: 13,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
