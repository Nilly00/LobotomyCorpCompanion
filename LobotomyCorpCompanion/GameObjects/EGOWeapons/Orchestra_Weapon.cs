namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Orchestra_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Orchestra_Weapon _instance = new Orchestra_Weapon();

        // Public accessor
        public static Orchestra_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Orchestra_Weapon() : base(
            name: "Da Capo",
            cost: 222,
            maxCount: 1,
            requirements: new int[] { 0, 5, 0, 0, 5 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.ALEPH,
            damageMin: 4,
            damageMax: 5,
            range: 1,
            attackSpeed: 1.0)
        {
        }

        internal override void WeaponCalculate()
        {
            //todo special calculation
        }
    }
}
