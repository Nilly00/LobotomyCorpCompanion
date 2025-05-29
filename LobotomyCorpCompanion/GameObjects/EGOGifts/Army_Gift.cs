namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Army_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Army_Gift _instance = new();

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
            if (SameWeapon(employee) && SameSuit(employee))
            {
                employee.PermanentBonuses.damagePercent *= 1.15;
            }
        }
    }
}