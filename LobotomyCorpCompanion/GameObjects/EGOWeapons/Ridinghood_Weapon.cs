namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Ridinghood_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Ridinghood_Weapon _instance = new Ridinghood_Weapon();

        // Public accessor
        public static Ridinghood_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Ridinghood_Weapon() : base(
            name: "Crimson Scar",
            cost: 70,
            maxCount: 1,
            requirements: new int[] { 3, 0, 0, 3, 0 },
            type: DamageType.RED,
            riskLevel: RiskLevel.WAW,
            damageMin: 11,
            damageMax: 13,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("While below 50% HP +50% damage and FRIENDLY FIRE!");
            employee.conditionalBoni.damagePercent *= 1.5;
        }
    }
}
