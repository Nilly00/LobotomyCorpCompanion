namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Punishing_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Punishing_Weapon _instance = new Punishing_Weapon();

        // Public accessor
        public static Punishing_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Punishing_Weapon() : base(
            name: "Beak",
            cost: 30,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.TETH,
            damageMin: 2,
            damageMax: 3,
            range: 10,
            attackSpeed: 0.7)
        {
        }
    }
}
