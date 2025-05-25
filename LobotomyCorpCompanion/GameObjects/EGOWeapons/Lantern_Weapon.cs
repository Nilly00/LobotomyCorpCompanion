namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Lantern_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Lantern_Weapon _instance = new Lantern_Weapon();

        // Public accessor
        public static Lantern_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Lantern_Weapon() : base(
            origin: Lantern.Instance,
            name: "Lantern",
            unlockLevel: 3,
            cost: 25,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.TETH,
            damageMin: 12,
            damageMax: 18,
            range: 5,
            attackSpeed: 3.0)
        {
        }
    }
}