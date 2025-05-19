namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Nothing_Gift : EgoGift_Cheek
    {
        // Singleton instance
        private static readonly Nothing_Gift _instance = new Nothing_Gift();

        // Public accessor
        public static Nothing_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Nothing_Gift() : base(
            name: "Mimicry",
            secondaryStats: new SecondaryStats(HP: 10)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.permanentBoni.HPHealing *= 1.05f;
        }
    }
}