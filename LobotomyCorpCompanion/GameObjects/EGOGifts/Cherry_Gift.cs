namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Cherry_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Cherry_Gift _instance = new Cherry_Gift();

        // Public accessor
        public static Cherry_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Cherry_Gift() : base(
            origin: Cherry.Instance,
            unlockLevel: 2,
            name: "Cherry Blossoms",

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(HP: 2, AS: 2, MS: 2)
        )
        { }
    }
}