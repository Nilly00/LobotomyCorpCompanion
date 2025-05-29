namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Apple_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Apple_Gift _instance = new();

        // Public accessor
        public static Apple_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apple_Gift() : base(
            origin: Apple.Instance,
            name: "Green Stem",
            unlockLevel: 2,

            slot: Slot.Brooch,
            secondaryStats: new SecondaryStats(SP: 6)
        )
        { }

        internal override void Effect(Employee employee)
        {
            if (true) //todo proper weapon check
            {
                employee.PermanentBonuses.damageFlat += 5;
            }
        }
    }
}