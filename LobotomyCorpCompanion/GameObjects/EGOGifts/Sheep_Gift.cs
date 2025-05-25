namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Sheep_Gift : EgoGift_Hat
    {
        // Singleton instance
        private static readonly Sheep_Gift _instance = new Sheep_Gift();

        // Public accessor
        public static Sheep_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Sheep_Gift() : base(
            origin: Wolf.Instance,
            unlockLevel: 0,
            name: "Sheep's clothing",
            secondaryStats: new SecondaryStats(HP: 9, SP: -3)
        )
        { }
        //todo custom unlock condition
    }
}