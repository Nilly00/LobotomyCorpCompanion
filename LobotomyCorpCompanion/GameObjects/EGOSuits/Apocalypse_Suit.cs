namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Apocalypse_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Apocalypse_Suit _instance = new();

        // Public accessor
        public static Apocalypse_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apocalypse_Suit() : base(
            origin: Apocalypse.Instance,
            name: "Twilight",
            unlockLevel: 0,

            cost: -1,
            maxCount: 1,
            requirements: [0, 0, 0, 0, 0],
            riskLevel: RiskLevel.ALEPH,

            resistances: new Resistances(0.3, 0.3, 0.3, 0.5)
            )
        {
        }

        internal override bool CheckRequirements(Employee employee)
        {
            return base.CheckRequirements(employee) &&
                employee.MinStats.PrimaryStats.Fortitude >= 110 &&
                employee.MinStats.PrimaryStats.Prudence >= 110 &&
                employee.MinStats.PrimaryStats.Temperance >= 110 &&
                employee.MinStats.PrimaryStats.Justice >= 110;
        }

        internal override void Effect(Employee employee)
        {

            if(SameWeapon(employee))
            {
                employee.SpecialEffects.Add("Damage increases when HP lowers.");
            }
            //prevents double adding of this effect as the weapon has the same effect
            else
            {
                employee.SpecialEffects.Add("Prevents Apocalypse Bird from appearing.");
            }
            if (SameWeapon(employee) && SameGift(employee))
            {
                employee.SpecialEffects.Add("Deal R/W/B/P damage to all enemies in the room every 5s");
            }
            else
            {
                employee.SpecialEffects.Add("Deal black damage to all enemies in the room every 5s");
            }

        }
    }
}