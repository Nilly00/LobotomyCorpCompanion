namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class MHZ_Gift : EgoGift
    {
        // Singleton instance
        private static readonly MHZ_Gift _instance = new MHZ_Gift();

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
            if (origin.SameSuit(employee))
            {
                employee.permanentBonuses.secondaryStats.SP -= 10;
                employee.permanentBonuses.secondaryStats.AS += 10;
            }
        }
    }
}