namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Sheep_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Sheep_Gift _instance = new();

        // Public accessor
        public static Sheep_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Sheep_Gift() : base(
            origin: Wolf.Instance,
            unlockLevel: 0,
            name: "Sheep's clothing",

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(HP: 9, SP: -3)
        )
        { }
        //todo custom unlock condition
    }
}