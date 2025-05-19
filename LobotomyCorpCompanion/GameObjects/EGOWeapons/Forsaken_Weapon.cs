namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Forsaken_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Forsaken_Weapon _instance = new Forsaken_Weapon();

        // Public accessor
        public static Forsaken_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Forsaken_Weapon() : base(
            name: "Regret",
            cost: 25,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.TETH,
            damageMin: 10,
            damageMax: 15,
            range: 5,
            attackSpeed: 3.0)
        {
        }
    }
}
