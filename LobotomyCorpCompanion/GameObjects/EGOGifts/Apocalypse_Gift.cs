namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Apocalypse_Gift : EgoGift_Right_Back
    {
        // Singleton instance
        private static readonly Apocalypse_Gift _instance = new Apocalypse_Gift();

        // Public accessor
        public static Apocalypse_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apocalypse_Gift() : base(
            origin: Apocalypse.Instance,
            name: "Twilight",
            unlockLevel: 0,
            secondaryStats: new SecondaryStats(7, 7, 7, 7, 7, 7)
        )
        { }
    }
}