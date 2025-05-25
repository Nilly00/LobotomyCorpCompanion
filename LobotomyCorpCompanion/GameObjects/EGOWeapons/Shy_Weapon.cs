namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Shy_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Shy_Weapon _instance = new Shy_Weapon();

        // Public accessor
        public static Shy_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Shy_Weapon() : base(
            origin: Shy.Instance,
            name: "Today's Expression",
            unlockLevel: 3,
            cost: 25,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.TETH,
            damageMin: 2,
            damageMax: 3,
            range: 10,
            attackSpeed: 0.7)
        {
        }
    }
}
