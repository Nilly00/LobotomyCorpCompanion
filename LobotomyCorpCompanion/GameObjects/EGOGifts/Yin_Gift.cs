namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Yin_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Yin_Gift _instance = new();

        // Public accessor
        public static Yin_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Yin_Gift() : base(
            origin: Yin.Instance,
            name: "Discord",
            unlockLevel: 3,

            slot: Slot.Helmet,
            secondaryStats: new SecondaryStats(HP: -10, SP: -10, AS: 20, MS: 20)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("8% chance to heal as much damake being taken when Attacked");
        }
    }
}