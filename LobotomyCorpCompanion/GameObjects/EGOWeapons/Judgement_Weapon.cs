namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Judgement_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Judgement_Weapon _instance = new Judgement_Weapon();

        // Public accessor
        public static Judgement_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Judgement_Weapon() : base(
            origin: Judgement.Instance,
            name: "Justitia",
            unlockLevel: 4,
            cost: 150,
            maxCount: 1,
            requirements: new int[] { 0, 0, 0, 5, 5 },
            type: DamageType.PALE,
            riskLevel: RiskLevel.ALEPH,
            damageMin: 2,
            damageMax: 4,
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
