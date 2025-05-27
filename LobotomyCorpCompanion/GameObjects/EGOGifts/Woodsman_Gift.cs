namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Woodsman_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Woodsman_Gift _instance = new Woodsman_Gift();

        // Public accessor
        public static Woodsman_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Woodsman_Gift() :  base(
            origin: Woodsman.Instance,
            name: "Logging",
            unlockLevel: 2,

            slot: Slot.Brooch,
            secondaryStats: new SecondaryStats(HP: 2, SR: 2, WS: 2)
        )
        { }
    }
}
