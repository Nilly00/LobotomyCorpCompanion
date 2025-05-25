namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Apocalypse_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Apocalypse_Suit _instance = new Apocalypse_Suit();

        // Public accessor
        public static Apocalypse_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apocalypse_Suit() : base(
            origin: Apocalypse.Instance,
            name: "Twilight",
            unlockLevel: 0,
            cost: -1,
            maxCount: 1,
            requirements: new int[] { 0, 0, 0, 0, 0 },
            riskLevel: RiskLevel.ALEPH,
            resistances: new Resistances(0.3, 0.3, 0.3, 0.5)
            )
        {
        }

        internal override bool CheckRequirements(Employee employee)
        {
            //todo implement special check
            return false;
        }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Deal black damage to all enemies in the room every 5s");
            if(origin.SameWeapon(employee))
            {
                employee.SpecialEffects.Add("Damage increases when HP lowers.");
            }
            employee.SpecialEffects.Add("Prevents Apocalypse Bird from appearing.");
        }
    }
}