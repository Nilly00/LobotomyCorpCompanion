namespace LobotomyCorpCompanion.GameObjects.EGOGifts
{
    internal sealed class Freischütz_Gift : EgoGift
    {
        // Singleton instance
        private static readonly Freischütz_Gift _instance = new Freischütz_Gift();

        // Public accessor
        public static Freischütz_Gift Instance => _instance;

        // Private constructor to prevent external instantiation
        private Freischütz_Gift() : base(
            origin: Freischütz.Instance,
            unlockLevel: 2,
            name: "Magic Bullet",

            slot: Slot.Mouth_2,
            secondaryStats: new SecondaryStats(HP: -5, SP: -5, AS: 10, MS: 10)
        )
        { }

        internal override void Effect(Employee employee)
        {
            if (SameWeapon(employee))
            {
                employee.permanentBonuses.damageFlat += 3;
            }
        }
    }
}