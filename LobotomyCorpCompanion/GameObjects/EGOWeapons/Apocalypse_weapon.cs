namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Apocalypse_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Apocalypse_Weapon _instance = new Apocalypse_Weapon();

        // Public accessor
        public static Apocalypse_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apocalypse_Weapon() : base(
            origin: Apocalypse.Instance,
            name: "Twilight",
            cost: 0,
            maxCount: 0,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            type: DamageType.SPECIAL,
            riskLevel: RiskLevel.ALEPH,
            damageMin: 0,
            damageMax: 0,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override bool CheckRequirements(Employee employee)
        {
            //todo special check
            return false;
        }

        internal override void Effect(Employee employee)
        {
            //todo special effect
        }

        internal override void WeaponCalculate()
        {
            //todo special calculate
        }
    }
}
