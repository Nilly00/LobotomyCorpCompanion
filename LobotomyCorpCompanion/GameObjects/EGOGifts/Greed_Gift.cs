namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Greed_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Greed_Gift _instance = new();

        // Public accessor
        public static Greed_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Greed_Gift() : base(
            origin: Greed.Instance,
            name: "Gold Rush",
            unlockLevel: 2,

            slot: Slot.Hand_1,
            secondaryStats: new SecondaryStats(HP: 6)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("INSTINCT SR +6%");
        }
    }
}