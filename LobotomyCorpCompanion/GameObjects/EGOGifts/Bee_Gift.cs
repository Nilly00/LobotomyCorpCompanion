namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class  Bee_Gift : EgoGift
    {
        // Singleton instance
        private static readonly  Bee_Gift _instance = new  Bee_Gift();

        // Public accessor
        public static  Bee_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private  Bee_Gift() : base(
            origin:  Bee.Instance,
            name: "Hornet",
            unlockLevel: 3,

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(HP: 2, SP: 4)
        )
        { }
    }
}