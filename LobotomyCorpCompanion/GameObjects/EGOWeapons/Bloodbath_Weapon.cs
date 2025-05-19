namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Bloodbath_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Bloodbath_Weapon _instance = new Bloodbath_Weapon();

        // Public accessor
        public static Bloodbath_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bloodbath_Weapon() : base(
            name: "Wrist Cutter",
            cost: 25,
            maxCount: 2,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.TETH,
            damageMin: 2,
            damageMax: 3,
            range: 2,
            attackSpeed: 0.7)
        {
        }

        internal override void Effect(Employee employee)
        {
            //todo special effect
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
