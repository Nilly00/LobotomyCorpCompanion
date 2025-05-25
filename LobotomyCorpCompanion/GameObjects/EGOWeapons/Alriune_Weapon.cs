namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Alriune_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Alriune_Weapon _instance = new Alriune_Weapon();

        // Public accessor
        public static Alriune_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Alriune_Weapon() : base(
            origin: Alriune.Instance,
            name: "Faint Aroma",
            unlockLevel: 4,
            cost: 60,
            maxCount: 2,
            requirements: new int[] { 0, 3, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.WAW,
            damageMin: 10,
            damageMax: 20,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}
