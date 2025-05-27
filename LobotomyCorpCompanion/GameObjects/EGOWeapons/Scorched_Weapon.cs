namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Scorched_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Scorched_Weapon _instance = new Scorched_Weapon();

        // Public accessor
        public static Scorched_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Scorched_Weapon() : base(
            origin: Scorched.Instance,
            name: "Fourth Match Flame",
            unlockLevel: 4,

            cost: 35,
            maxCount: 1,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.RED, 
            damageMin: 20,
            damageMax: 30,
            range: 15,
            attackSpeed: 5.0)
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
