namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class OneSin_Gift : EgoGift
    {
        // Singleton instance
        private static readonly OneSin_Gift _instance = new OneSin_Gift();

        // Public accessor
        public static OneSin_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private OneSin_Gift() : base(
            origin: OneSin.Instance,
            name: "Penitence",
            unlockLevel: 1,

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(SP: 2)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Work Success Rate +10% with One Sin");
        }
    }
}