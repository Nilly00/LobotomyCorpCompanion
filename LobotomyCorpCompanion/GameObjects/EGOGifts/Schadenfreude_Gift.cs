namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Schadenfreude_Gift : EgoGift_Hand_2
    {
        // Singleton instance
        private static readonly Schadenfreude_Gift _instance = new Schadenfreude_Gift();

        // Public accessor
        public static Schadenfreude_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Schadenfreude_Gift() : base(
            origin: Schadenfreude.Instance,
            name: "Gaze",
            unlockLevel: 2,
            secondaryStats: new SecondaryStats(HP: 4)
        )
        { }
    }
}