namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Fairy_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Fairy_Gift _instance = new Fairy_Gift();

        // Public accessor
        public static Fairy_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fairy_Gift() : base(
            origin: Fairy.Instance,
            unlockLevel: 1,
            name: "Wingbeat",

            slot: Slot.Hand_2,
            secondaryStats: new SecondaryStats(SR: 2, WS: 2)
        )
        { }
    }
}