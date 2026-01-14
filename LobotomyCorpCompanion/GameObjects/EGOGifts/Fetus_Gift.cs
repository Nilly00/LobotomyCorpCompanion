namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Fetus_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Fetus_Gift _instance = new();

        // Public accessor
        public static Fetus_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fetus_Gift() : base(
            origin: Fetus.Instance,
            name: "Syrinx",
            unlockLevel: 2,

            slot: Slot.Helmet,
            secondaryStats: new SecondaryStats(HP: -2, SP: -2, AS: 6, MS: 6)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.PermanentBonuses.Resistances.White *= 0.95;
        }
    }
}