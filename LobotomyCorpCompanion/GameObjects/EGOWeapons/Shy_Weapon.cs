namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Shy_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Shy_Weapon _instance = new();

        // Public accessor
        public static Shy_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Shy_Weapon() : base(
            origin: Shy.Instance,
            name: "Today's Expression",
            unlockLevel: 3,

            cost: 25,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.BLACK, 
            damageMin: 2,
            damageMax: 3,
            range: 10,
            attackSpeed: 0.7)
        {
        }
    }
}
