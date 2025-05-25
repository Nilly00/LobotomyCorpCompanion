namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Bloodbath_Gift : EgoGift_Hand_2
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
            secondaryStats: new SecondaryStats(SR: 2, WS: 2)
        )
        { }
    }
}