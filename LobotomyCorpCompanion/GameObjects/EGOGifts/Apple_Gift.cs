namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Apple_Gift : EgoGift_Brooch
    {
        // Singleton instance
        private static readonly Apple_Gift _instance = new Apple_Gift();

        // Public accessor
        public static Apple_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apple_Gift() : base(
            name: "Green Stem",
            secondaryStats: new SecondaryStats(SP: 6)
        )
        { }

        internal override void Effect(Employee employee)
        {
            if (true) //todo proper weapon check
            {
                employee.permanentBoni.damageFlat += 5;
            }
        }
    }
}