namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Beauty_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Beauty_Weapon _instance = new();

        // Public accessor
        public static Beauty_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Beauty_Weapon() : base(
            origin:Beauty.Instance,
            name: "Horn",
            unlockLevel: 3,

            cost: 30,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.RED, 
            damageMin: 5,
            damageMax: 9,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
