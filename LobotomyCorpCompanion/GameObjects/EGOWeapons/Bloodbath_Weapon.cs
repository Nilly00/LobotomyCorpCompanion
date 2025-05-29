namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Bloodbath_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Bloodbath_Weapon _instance = new();

        // Public accessor
        public static Bloodbath_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bloodbath_Weapon() : base(
            origin: Bloodbath.Instance,
            unlockLevel: 3,
            name: "Wrist Cutter",

            cost: 25,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.WHITE, 
            damageMin: 2,
            damageMax: 3,
            range: 2,
            attackSpeed: 0.7)
        {
        }
    }
}
