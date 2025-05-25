namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Ridinghood_Gift : EgoGift_Mouth_1
    {
        // Singleton instance
        private static readonly Ridinghood_Gift _instance = new Ridinghood_Gift();

        // Public accessor
        public static Ridinghood_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Ridinghood_Gift() : base(
            origin: Ridinghood.Instance,
            name: "Crimson Scar",
            unlockLevel: 3,
            secondaryStats: new SecondaryStats(HP: 3, AS: 3, WS: 3)
        )
        { }
    }
}