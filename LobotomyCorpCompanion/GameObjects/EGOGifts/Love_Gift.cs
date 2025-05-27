namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Love_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Love_Gift _instance = new Love_Gift();

        // Public accessor
        public static Love_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Love_Gift() : base(
            origin: Love.Instance,
            name: "Adoration",
            unlockLevel: 4,

            slot: Slot.Helmet,
            secondaryStats: new SecondaryStats(HP: 5, SP: 10, SR: -5, WS: -5)
        )
        { }

        internal override void Effect(Employee employee)
        {
            if (SameSuit(employee))
            {
                employee.SpecialEffects.Add("When falling below 20% HP gain a 100 RED shield that lasts for 3 seconds. 12 Second Cooldown. Half MS while shielded");
            }
        }
    }
}