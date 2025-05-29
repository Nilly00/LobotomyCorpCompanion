namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Nothing_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Nothing_Gift _instance = new();

        // Public accessor
        public static Nothing_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nothing_Gift() : base(
            origin: Nothing.Instance,
            name: "Mimicry",
            unlockLevel: 4,

            slot: Slot.Cheek,
            secondaryStats: new SecondaryStats(HP: 10)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.PermanentBonuses.HPHealing *= 1.05f;
        }
    }
}