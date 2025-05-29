namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Bee_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Bee_Weapon _instance = new();

        // Public accessor
        public static Bee_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bee_Weapon() : base(
            origin: Bee.Instance,
            name: "Hornet",
            unlockLevel: 4,

            cost: 60,
            maxCount: 2,
            requirements: [3, 0, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.RED, 
            damageMin: 7,
            damageMax: 8,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
