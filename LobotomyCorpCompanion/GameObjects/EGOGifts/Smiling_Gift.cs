namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Smiling_Gift : EgoGift_Eye
    {
        // Singleton instance
        private static readonly Smiling_Gift _instance = new Smiling_Gift();

        // Public accessor
        public static Smiling_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Smiling_Gift() : base(
            origin: Smiling.Instance,
            name: "Smile",
            unlockLevel: 3,
            secondaryStats: new SecondaryStats(HP: 5, SP: 5)
        )
        { }
    }
}