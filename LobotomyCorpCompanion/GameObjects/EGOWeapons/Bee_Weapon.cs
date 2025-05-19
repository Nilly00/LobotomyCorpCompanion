namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Bee_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Bee_Weapon _instance = new Bee_Weapon();

        // Public accessor
        public static Bee_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bee_Weapon() : base(
            name: "Hornet",
            cost: 60,
            maxCount: 2,
            requirements: new int[] { 3, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.WAW,
            damageMin: 7,
            damageMax: 8,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
