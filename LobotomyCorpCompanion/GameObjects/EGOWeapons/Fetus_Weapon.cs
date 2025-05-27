namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Fetus_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Fetus_Weapon _instance = new Fetus_Weapon();

        // Public accessor
        public static Fetus_Weapon Instance => _instance;


        // Private constructor to prevent external instantiation
        private Fetus_Weapon() : base(
            origin: Fetus.Instance,
            name: "Syrinx",
            unlockLevel: 4,

            cost: 45,
            maxCount: 1,
            requirements: [2, 0, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            type: DamageType.WHITE,
            damageMin: 3,
            damageMax: 3,
            range: 10,
            attackSpeed: 0.5)
        {
        }
    }
}
