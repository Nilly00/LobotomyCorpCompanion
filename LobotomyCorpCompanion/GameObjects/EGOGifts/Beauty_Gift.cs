namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Beauty_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Beauty_Gift _instance = new Beauty_Gift();

        // Public accessor
        public static Beauty_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Beauty_Gift() : base(
            origin: Beauty.Instance,
            name: "Horn",
            unlockLevel: 2,

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(HP: 2, SP: 2)
        )
        { }
    }
}