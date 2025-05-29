namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Galaxy_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Galaxy_Gift _instance = new();

        // Public accessor
        public static Galaxy_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Galaxy_Gift() : base(
            origin: Galaxy.Instance,
            unlockLevel: 2,
            name: "Our Galaxy",

            slot: Slot.Neckwear,
            secondaryStats: new SecondaryStats(SR: 3, WS: 3)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Periodically recover a small amount of HP");
        }
    }
}