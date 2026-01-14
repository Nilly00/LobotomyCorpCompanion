namespace LobotomyCorpCompanion.GameObjects.EGOSuits
{
    internal sealed class Spider_Suit : EgoSuit
    {
        // Singleton instance
        private static readonly Spider_Suit _instance = new();

        // Public accessor
        public static Spider_Suit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Spider_Suit() : base(
            origin: Spider.Instance,
            name: "Red Eyes",
            unlockLevel: 2,

            cost: 30,
            maxCount: 1,
            requirements: [2, 0, 0, 0, 0],
            riskLevel: RiskLevel.TETH,

            resistances: new Resistances(0.8, 0.8, 0.8, 2.0)
            )
        {
        }

        internal override void Effect(Employee employee)
        {
            //If the Weapon is the same the Weapon will already have checked for 
            //the Presence of the Suit and added +5 instead of it's usual +2
            if(!SameWeapon(employee))
            {
                employee.PermanentBonuses.SecondaryStats.MS += 2;
            }
        }
    }
}