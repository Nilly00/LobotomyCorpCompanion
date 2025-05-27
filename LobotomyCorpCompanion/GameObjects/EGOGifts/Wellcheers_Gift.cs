namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Wellcheers_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Wellcheers_Gift _instance = new Wellcheers_Gift();

        // Public accessor
        public static Wellcheers_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Wellcheers_Gift() : base(
            origin: Wellcheers.Instance,
            name: "Soda",
            unlockLevel: 1,

            slot: Slot.Mouth_2,
            secondaryStats: new SecondaryStats(HP: 2)
        )
        { }
    }
}