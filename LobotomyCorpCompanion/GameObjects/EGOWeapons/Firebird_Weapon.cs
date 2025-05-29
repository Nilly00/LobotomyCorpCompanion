namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Firebird_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Firebird_Weapon _instance = new();

        // Public accessor
        public static Firebird_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Firebird_Weapon() : base(
            origin: Firebird.Instance,
            name: "Feather of Honour",
            unlockLevel: 0,

            cost: -1,
            maxCount: 3,
            requirements: [3, 0, 0, 0, 0],
            riskLevel: RiskLevel.WAW,

            type: DamageType.WHITE, 
            damageMin: 4,
            damageMax: 5,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
