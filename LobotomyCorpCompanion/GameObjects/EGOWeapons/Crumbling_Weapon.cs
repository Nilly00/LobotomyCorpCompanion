namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Crumbling_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Crumbling_Weapon _instance = new();

        // Public accessor
        public static Crumbling_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Crumbling_Weapon() : base(
            origin: Crumbling.Instance,
            name: "Life for a Daredevil",
            unlockLevel: 3,

            cost: 35,
            maxCount: 1,
            requirements: [0, 0, 2, 0, 0],
            riskLevel: RiskLevel.HE,

            type: DamageType.PALE, 
            damageMin: 7,
            damageMax: 9,
            range: 4,
            attackSpeed: 1.3)
        {
        }
    }
}
