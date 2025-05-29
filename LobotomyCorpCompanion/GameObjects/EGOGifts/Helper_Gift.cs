namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Helper_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Helper_Gift _instance = new();

        // Public accessor
        public static Helper_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Helper_Gift() : base(
            origin: Helper.Instance,
            name: "Grinder Mk4",
            unlockLevel: 2,

            slot: Slot.Eye,
            secondaryStats: new SecondaryStats(SR: 2, WS: 2)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("INSIGHT SR +3%");
        }
    }
}