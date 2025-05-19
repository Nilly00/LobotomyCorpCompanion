namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Laetitia_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Laetitia_Weapon _instance = new Laetitia_Weapon();

        // Public accessor
        public static Laetitia_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Laetitia_Weapon() : base(
            name: "Laetitia",
            cost: 40,
            maxCount: 2,
            requirements: new int[] { 0, 2, 0, 0, 0 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.HE,
            damageMin: 5,
            damageMax: 6,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
