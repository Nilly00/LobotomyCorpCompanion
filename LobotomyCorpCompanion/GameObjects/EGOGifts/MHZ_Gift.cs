namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class MHZ_Gift : EgoGift_Brooch
    {
        // Singleton instance
        private static readonly MHZ_Gift _instance = new MHZ_Gift();

        // Public accessor
        public static MHZ_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private MHZ_Gift() : base(
            name: "Noise",
            secondaryStats: new SecondaryStats(AS: 2)
        )
        { }

        internal override void Effect(Employee employee)
        {
            if (true) //todo add suit depencency
            {
                employee.permanentBoni.secondaryStats.SP -= 10;
                employee.permanentBoni.secondaryStats.AS += 10;
            }
        }
    }
}