namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal class Crumbling_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Crumbling_Gift _instance = new Crumbling_Gift();

        // Public accessor
        public static Crumbling_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Crumbling_Gift() : base(
            origin: Crumbling.Instance,
            name: "Inspired Bravery",
            unlockLevel: 0,

            slot: Slot.Hat,
            secondaryStats: new SecondaryStats(AS: 10, MS: 10)
        )
        { }

        internal override void Effect(Employee employee)
        {
            employee.SpecialEffects.Add("Will die if peforming ATTACHMENT Work or using a Tool abnormality");
        }


        // Constructor for derived classes to use
        protected Crumbling_Gift(string name, SecondaryStats secondaryStats) : base(Crumbling.Instance, name, 0, Slot.Hat, secondaryStats) { }
    }

    internal sealed class Crumbling_B_Gift : Crumbling_Gift
    {
        // Singleton instance
        private static readonly Crumbling_B_Gift _instance = new Crumbling_B_Gift();

        // Public accessor
        public static new Crumbling_B_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Crumbling_B_Gift() : base(
            name: "Reckless Foolishness (Blue)",
            secondaryStats: new SecondaryStats(HP: -5, AS: 10, MS: 10)
        )
        { }
    }
    internal sealed class Crumbling_O_Gift : Crumbling_Gift
    {
        // Singleton instance
        private static readonly Crumbling_O_Gift _instance = new Crumbling_O_Gift();

        // Public accessor
        public static new Crumbling_O_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Crumbling_O_Gift() : base(
            name: "Reckless Foolishness (Orange)",
            secondaryStats: new SecondaryStats(HP: -10, AS: 15, MS: 15)
        )
        { }
        }
    internal sealed class Crumbling_R_Gift : Crumbling_Gift
    {
        // Singleton instance
        private static readonly Crumbling_R_Gift _instance = new Crumbling_R_Gift();

        // Public accessor
        public static new Crumbling_R_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Crumbling_R_Gift() : base(
            name: "Reckless Foolishness (Red)",
            secondaryStats: new SecondaryStats(HP: -20, AS: 20, MS: 20)
        )
        { }
    }
}