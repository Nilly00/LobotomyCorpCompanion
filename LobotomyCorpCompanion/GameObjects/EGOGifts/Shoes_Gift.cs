namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Shoes_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Shoes_Gift _instance = new Shoes_Gift();

        // Public accessor
        public static Shoes_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Shoes_Gift() : base(
            origin: Shoes.Instance,
            name: "Sanguine Desire",
            unlockLevel: 2,

            slot: Slot.Mouth_2,
            secondaryStats: new SecondaryStats(HP: 4)
        )
        { }

        internal override void Effect(Employee employee)
        {
            if (origin.SameWeapon(employee))
            {
                employee.permanentBonuses.secondaryStats.SR -= 10;
                employee.permanentBonuses.secondaryStats.WS -= 10;
                employee.permanentBonuses.secondaryStats.AS += 10;
            }
        }
    }
}