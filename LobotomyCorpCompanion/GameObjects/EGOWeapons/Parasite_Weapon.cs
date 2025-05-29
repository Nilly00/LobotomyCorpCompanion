namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Parasite_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Parasite_Weapon _instance = new();

        // Public accessor
        public static Parasite_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Parasite_Weapon() : base(
            origin: Parasite.Instance,
            name: "Hypocrisy",
            unlockLevel: 4,

            cost: 60,
            maxCount: 2,
            requirements: [0, 3, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.RED, 
            damageMin: 10,
            damageMax: 20,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
