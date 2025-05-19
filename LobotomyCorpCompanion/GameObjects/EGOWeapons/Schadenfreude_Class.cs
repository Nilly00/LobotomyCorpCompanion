namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Schadenfreude_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Schadenfreude_Weapon _instance = new Schadenfreude_Weapon();

        // Public accessor
        public static Schadenfreude_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Schadenfreude_Weapon() : base(
            name: "Gaze",
            cost: 45,
            maxCount: 1,
            requirements: new int[] { 0, 2, 2, 0, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.HE,
            damageMin: 1,
            damageMax: 4,
            range: 4,
            attackSpeed: 2.9)
        {
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
