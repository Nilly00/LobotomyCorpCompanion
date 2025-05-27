namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Snow_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Snow_Weapon _instance = new Snow_Weapon();

        // Public accessor
        public static Snow_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Snow_Weapon() : base(
            origin: Snow.Instance,
            name: "Frost Splinter",
            unlockLevel: 3,

            cost: 35,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.HE,

            type: DamageType.WHITE, 
            damageMin: 6,
            damageMax: 12,
            range: 4,
            attackSpeed: 1.5)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Reduces the Movement Speed of the target by 30% for 3 seconds");
        }
    }
}
