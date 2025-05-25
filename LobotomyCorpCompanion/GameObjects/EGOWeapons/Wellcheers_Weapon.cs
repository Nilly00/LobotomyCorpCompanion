namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Wellcheers_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Wellcheers_Weapon _instance = new Wellcheers_Weapon();

        // Public accessor
        public static Wellcheers_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Wellcheers_Weapon() : base(
            origin: Wellcheers.Instance,
            name: "Soda",
            unlockLevel: 3,
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
