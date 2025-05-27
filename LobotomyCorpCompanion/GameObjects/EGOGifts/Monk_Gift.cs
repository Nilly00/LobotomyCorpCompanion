namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Monk_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Monk_Gift _instance = new Monk_Gift();

        // Public accessor
        public static Monk_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Monk_Gift() : base(
            origin: Monk.Instance,
            unlockLevel: 3,
            name: "Amita",

            slot: Slot.Hand_1,
            secondaryStats: new SecondaryStats(HP: 10, SP: -4)
        )
        { }
    }
}