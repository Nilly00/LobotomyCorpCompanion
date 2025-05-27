namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Singing_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Singing_Gift _instance = new Singing_Gift();

        // Public accessor
        public static Singing_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Singing_Gift() : base(
            origin: Singing.Instance,
            name: "Harmony",
            unlockLevel: 3,

            slot: Slot.Cheek,
            secondaryStats: new SecondaryStats(HP: 8, SP: -4)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Upon taking WHITE damage, recover 20% of the damage as SP and Attack Speed +10");
            employee.conditionalBonuses.secondaryStats.AS += 10;
        }
    }
}