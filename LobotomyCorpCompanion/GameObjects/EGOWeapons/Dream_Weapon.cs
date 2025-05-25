namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Dream_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Dream_Weapon _instance = new Dream_Weapon();

        // Public accessor
        public static Dream_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Dream_Weapon() : base(
            origin: Dream.Instance,
            name: "Engulfing Dream",
            unlockLevel: 3,
            cost: 25,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.TETH,
            damageMin: 1,
            damageMax: 2,
            range: 8,
            attackSpeed: 1.0)
        {
        }
    }
}
