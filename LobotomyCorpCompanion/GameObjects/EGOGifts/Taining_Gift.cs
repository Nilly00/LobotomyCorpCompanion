namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Rabbit_Gift : EgoGift_Hat
    {
        // Singleton instance
        private static readonly Rabbit_Gift _instance = new Rabbit_Gift();

        // Public accessor
        public static Rabbit_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rabbit_Gift() : base(
            origin: Rabbit.Instance,
            name: "Standard Training E.G.O",
            unlockLevel: 4,
            secondaryStats: new SecondaryStats(HP: 2, SP: 2)
        )
        { }
    }
}