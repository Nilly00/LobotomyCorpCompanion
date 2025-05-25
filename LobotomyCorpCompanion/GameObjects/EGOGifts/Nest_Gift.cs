namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Nest_Gift : EgoGift_Hand_2
    {
        // Singleton instance
        private static readonly Nest_Gift _instance = new Nest_Gift();

        // Public accessor
        public static Nest_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nest_Gift() : base(
            origin: Nest.Instance,
            name: "Exuviae",
            unlockLevel: 4,
            secondaryStats: new SecondaryStats(HP: 5, SP: 2)
        )
        { }
    }
}