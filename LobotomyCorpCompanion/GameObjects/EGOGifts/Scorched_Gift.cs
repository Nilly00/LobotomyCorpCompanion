namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Scorched_Gift : EgoGift_Mouth_2
    {
        // Singleton instance
        private static readonly Scorched_Gift _instance = new Scorched_Gift();

        // Public accessor
        public static Scorched_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Scorched_Gift() : base(
            origin: Scorched.Instance,
            name: "Fourth Match Flame",
            unlockLevel: 2,
            secondaryStats: new SecondaryStats(HP: 4)
        )
        { }
    }
}