namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Fragments_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Fragments_Weapon _instance = new Fragments_Weapon();

        // Public accessor
        public static Fragments_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fragments_Weapon() : base(
            origin: Fragments.Instance,
            name: "Fragments from Somewhere",
            unlockLevel: 3,

            cost: 20,
            maxCount: 3,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            type: DamageType.BLACK, 
            damageMin: 5,
            damageMax: 9,
            range: 4,
            attackSpeed: 1.5)
        {
        }

        internal override void Effect(Employee employee)
        {
            if (employee.ranks[1] > 5)
            {
                employee.SpecialEffects.Add("On Hit 10% chance for +40% SP for 30 seconds");
            }
        }
    }
}