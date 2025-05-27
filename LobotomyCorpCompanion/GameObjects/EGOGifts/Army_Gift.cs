namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Army_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Army_Gift _instance = new Army_Gift();

        // Public accessor
        public static Army_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Army_Gift() : base(
            origin: Army.Instance,
            unlockLevel: 4,
            name: "Pink",

            slot: Slot.Helmet,
            secondaryStats: new SecondaryStats(AS: 5, MS: 5)
        )
        { }

        internal override void Effect(Employee employee)
        {
            if (origin.SameWeapon(employee) && origin.SameSuit(employee))
            {
                employee.permanentBonuses.damagePercent *= 1.15;
            }
        }
    }
}