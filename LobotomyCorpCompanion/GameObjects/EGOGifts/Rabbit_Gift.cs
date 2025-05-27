namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Rabbit_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Rabbit_Gift _instance = new Rabbit_Gift();

        // Public accessor
        public static Rabbit_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rabbit_Gift() : base(
            origin: Rabbit.Instance,
            name: "Standard Training E.G.O",
            unlockLevel: 4,

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(HP: 2, SP: 2)
        )
        { }
    }
}