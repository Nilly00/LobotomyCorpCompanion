namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Woodsman_Gift : EgoGift_Brooch
    {
        // Singleton instance
        private static readonly Woodsman_Gift _instance = new Woodsman_Gift();

        // Public accessor
        public static Woodsman_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Woodsman_Gift() :  base(
            name: "Logging",
            secondaryStats: new SecondaryStats(HP: 2, SR: 2, WS: 2)
        )
        { }
    }
}
