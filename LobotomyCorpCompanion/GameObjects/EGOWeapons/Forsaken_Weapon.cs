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
            origin: Forsaken.Instance,
            name: "Regret",
            unlockLevel: 4,

            cost: 25,
            maxCount: 2,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.RED, 
            damageMin: 10,
            damageMax: 15,
            range: 5,
            attackSpeed: 3.0)
        {
        }
    }
}
