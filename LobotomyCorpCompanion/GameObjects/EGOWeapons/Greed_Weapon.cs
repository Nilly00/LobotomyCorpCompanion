namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Greed_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Greed_Weapon _instance = new Greed_Weapon();

        // Public accessor
        public static Greed_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Greed_Weapon() : base(
            name: "Gold Rush",
            cost: 100,
            maxCount: 1,
            requirements: new int[] { 5, 0, 0, 0, 5 },
            type: DamageType.RED,
            riskLevel: RiskLevel.ALEPH,
            damageMin: 5,
            damageMax: 6,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("On each attack, 10% chance to buff Min. and Max. Attack Power by +5 for 12 seconds and reduce Temperance by 50% for 120 seconds.");
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
