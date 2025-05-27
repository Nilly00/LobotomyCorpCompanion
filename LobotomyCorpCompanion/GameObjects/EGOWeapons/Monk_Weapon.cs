namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Monk_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Monk_Weapon _instance = new Monk_Weapon();

        // Public accessor
        public static Monk_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Monk_Weapon() : base(
            origin: Monk.Instance,
            name: "Amita",
            unlockLevel: 4,

            cost: 70,
            maxCount: 1,
            requirements: [3, 0, 0, 0, 3],
            riskLevel: RiskLevel.WAW,

            type: DamageType.RED, 
            damageMin: 3,
            damageMax: 4,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
