namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Orchestra_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Orchestra_Gift _instance = new Orchestra_Gift();

        // Public accessor
        public static Orchestra_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Orchestra_Gift() : base(
            origin: Orchestra.Instance,
            name: "Da Capo",
            unlockLevel: 4,

            slot: Slot.Eye,
            secondaryStats: new SecondaryStats(SR: 4, WS: 4)
        )
        { }

        internal override void Effect(Employee employee)
        {
            if (origin.SameSuit(employee))
            {
                //todo set white resist to -1
            }
        }
    }
}