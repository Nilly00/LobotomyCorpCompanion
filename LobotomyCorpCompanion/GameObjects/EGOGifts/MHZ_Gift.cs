namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class MHZ_Gift : EgoGift
    {
        // Singleton instance
        private static readonly MHZ_Gift _instance = new();

        // Public accessor
        public static MHZ_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private MHZ_Gift() : base(
            origin: MHZ.Instance,
            name: "Noise",
            unlockLevel: 3,

            slot: Slot.Brooch,
            secondaryStats: new SecondaryStats(AS: 2, MS:2)
        )
        { }

        internal override void Effect(Employee employee)
        {
            if (SameSuit(employee))
            {
                employee.PermanentBonuses.secondaryStats.SP -= 10;
                employee.PermanentBonuses.secondaryStats.AS += 10;
            }
        }
    }
}