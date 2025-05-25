namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Rudolta_Gift : EgoGift_Hat
    {
        // Singleton instance
        private static readonly Rudolta_Gift _instance = new Rudolta_Gift();

        // Public accessor
        public static Rudolta_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rudolta_Gift() : base(
            origin: Rudolta.Instance,
            name: "Christmas",
            unlockLevel: 2,
            secondaryStats: new SecondaryStats(HP: -4, SP: 8)
        )
        { }
    }
}