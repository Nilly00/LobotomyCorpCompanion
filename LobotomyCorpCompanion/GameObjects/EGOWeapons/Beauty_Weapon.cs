namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Beauty_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Beauty_Weapon _instance = new Beauty_Weapon();

        // Public accessor
        public static Beauty_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Beauty_Weapon() : base(
            name: "Horn",
            cost: 30,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.TETH,
            damageMin: 5,
            damageMax: 9,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
