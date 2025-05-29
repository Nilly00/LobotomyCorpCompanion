namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Rudolta_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Rudolta_Weapon _instance = new();

        // Public accessor
        public static Rudolta_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rudolta_Weapon() : base(
            origin: Rudolta.Instance,
            name: "Christmas",
            unlockLevel: 3,

            cost: 35,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            type: DamageType.WHITE, 
            damageMin: 11,
            damageMax: 13,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
