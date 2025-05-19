namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Rudolta_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Rudolta_Weapon _instance = new Rudolta_Weapon();

        // Public accessor
        public static Rudolta_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rudolta_Weapon() : base(
            name: "Christmas",
            cost: 35,
            maxCount: 3,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.HE,
            damageMin: 11,
            damageMax: 13,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
