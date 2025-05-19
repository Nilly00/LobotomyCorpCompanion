namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class WellCheers_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly WellCheers_Weapon _instance = new WellCheers_Weapon();

        // Public accessor
        public static WellCheers_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private WellCheers_Weapon() : base(
            name: "Soda",
            cost: 20,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.ZAYIN,
            damageMin: 1,
            damageMax: 2,
            range: 10,
            attackSpeed: 0.7)
        {
        }
    }
}
