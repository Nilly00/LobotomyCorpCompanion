namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Punishing_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Punishing_Weapon _instance = new();

        // Public accessor
        public static Punishing_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Punishing_Weapon() : base(
            origin: Punishing.Instance,
            name: "Beak",
            unlockLevel: 3,

            cost: 30,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.RED, 
            damageMin: 2,
            damageMax: 3,
            range: 10,
            attackSpeed: 0.7)
        {
        }
    }
}
