namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Bloodbath_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Bloodbath_Gift _instance = new Bloodbath_Gift();

        // Public accessor
        public static Bloodbath_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bloodbath_Gift() : base(
            origin: Bloodbath.Instance,
            unlockLevel: 4,
            name: "Wrist Cutter",

            slot: Slot.Hand_2,
            secondaryStats: new SecondaryStats(SR: 2, WS: 2)
        )
        { }
    }
}