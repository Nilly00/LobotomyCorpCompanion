namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Army_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Army_Weapon _instance = new Army_Weapon();

        // Public accessor
        public static Army_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Army_Weapon() : base(
            origin: Army.Instance,
            name: "Pink",
            unlockLevel: 4,

            cost: 222,
            maxCount: 1,
            requirements: [0, 5, 0, 0, 5],
            riskLevel: RiskLevel.ALEPH,

            type: DamageType.WHITE, 
            damageMin: 20,
            damageMax: 24,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Requires 2 seconds of setup time before commencing attack.");
        }
    }
}
