namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Shoes_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Shoes_Gift _instance = new();

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
            if (SameWeapon(employee))
            {
                employee.PermanentBonuses.SecondaryStats.SR -= 10;
                employee.PermanentBonuses.SecondaryStats.WS -= 10;
                employee.PermanentBonuses.SecondaryStats.AS += 10;
            }
        }
    }
}