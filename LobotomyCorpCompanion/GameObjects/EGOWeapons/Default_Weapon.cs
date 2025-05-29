namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Default_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Default_Weapon _instance = new();

        // Public accessor
        public static Default_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Default_Weapon() : base(
            origin: Default.Instance,
            name: "Standard Riot Stick",
            unlockLevel: 0,

            cost: -1,
            maxCount: -1,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.ZAYIN,

            type: DamageType.RED, 
            damageMin: 4,
            damageMax: 6,
            range: 3,
            attackSpeed: 1.0)
        {
        }
    }
}
