namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Nest_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Nest_Gift _instance = new();

        // Public accessor
        public static Nest_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nest_Gift() : base(
            origin: Nest.Instance,
            name: "Exuviae",
            unlockLevel: 4,

            slot: Slot.Hand_2,
            secondaryStats: new SecondaryStats(HP: 5, SP: 2)
        )
        { }
    }
}