namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Woodsman_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Woodsman_Weapon _instance = new Woodsman_Weapon();

        // Public accessor
        public static Woodsman_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Woodsman_Weapon() : base(
            origin: Woodsman.Instance,
            name: "Logging",
            unlockLevel: 4,
            cost: 60,
            maxCount: 2,
            requirements: new int[] { 0, 2, 0, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.HE,
            damageMin: 15,
            damageMax: 21,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
