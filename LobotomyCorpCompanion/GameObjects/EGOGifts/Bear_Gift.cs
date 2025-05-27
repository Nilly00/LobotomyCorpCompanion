namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Bear_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Bear_Gift _instance = new Bear_Gift();

        // Public accessor
        public static Bear_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bear_Gift() : base(
            origin: Bear.Instance,
            unlockLevel: 2,
            name: "Bear Paws",

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(SP: 4)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("ATTACHMENT SR +3%");
        }
    }
}